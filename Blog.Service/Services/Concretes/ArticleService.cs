using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Extensions;
using Blog.Service.Helpers.Images;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Blog.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal user;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            user = httpContextAccessor.HttpContext.User;
            this.imageHelper = imageHelper;
        }

        public async Task<ArticleListDto> GetAllByPagingAsync(Guid? categoryId, int currentPage = 1, int pageSize = 8, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var articles = categoryId == null
                ? await unitOfWork.GetRepository<Article>().GetAllAsync(a => !a.isDeleted, a => a.Category, i => i.Image, u => u.User)
                : await unitOfWork.GetRepository<Article>().GetAllAsync(a => a.CategoryId == categoryId && !a.isDeleted,
                    a => a.Category, i => i.Image, u => u.User);
            var sortedArticles = isAscending
                ? articles.OrderBy(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : articles.OrderByDescending(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new ArticleListDto
            {
                Articles = sortedArticles,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = articles.Count,
                IsAscending = isAscending
            };
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            //var userId = Guid.Parse("B31EB5CC-FF98-4979-B273-DB39087C6AE8");

            var userId = user.GetLoggedInUserId();
            var userEmail = user.GetLoggedInEmail();

            var imageUpload = await imageHelper.Upload(articleAddDto.Title, articleAddDto.Photo, ImageType.Post);
            Blog.Entity.Entities.Image image = new(imageUpload.FullName, articleAddDto.Photo.ContentType, userEmail);
            await unitOfWork.GetRepository<Blog.Entity.Entities.Image>().AddAsync(image);

            var article = new Article(articleAddDto.Title, articleAddDto.Content, userId, articleAddDto.CategoryId, image.Id, userEmail);

            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.isDeleted && x.Id == articleId, x => x.Category, x => x.Image, u => u.User);
            var map = mapper.Map<ArticleDto>(articles);

            return map;
        }

        private async Task<Guid> UploadImageForArticle(ArticleUpdateDto articleUpdateDto)
        {
            var userEmail = user.GetLoggedInEmail();

            var imageUpload = await imageHelper.Upload(articleUpdateDto.Title, articleUpdateDto.Photo, ImageType.User);
            Blog.Entity.Entities.Image image = new(imageUpload.FullName, articleUpdateDto.Photo.ContentType, userEmail);
            await unitOfWork.GetRepository<Blog.Entity.Entities.Image>().AddAsync(image);

            return image.Id;
        }

        public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var userEmail = user.GetLoggedInEmail();
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.isDeleted && x.Id == articleUpdateDto.Id, x => x.Category, i => i.Image);
            var imageId = article.ImageId;

            mapper.Map(articleUpdateDto, article);
            //article.Title = articleUpdateDto.Title;
            //article.Content = articleUpdateDto.Content;
            //article.CategoryId = articleUpdateDto.CategoryId;
            article.ModifiedDate = DateTime.Now;
            article.ModifiedBy = userEmail;

            if (articleUpdateDto.Photo != null)
            {
                article.ImageId = await UploadImageForArticle(articleUpdateDto);
            }
            else
            {
                article.ImageId = imageId;
            }

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }
        public async Task<string> SafeDeleteArticleAsync(Guid articleId)
        {
            var userEmail = user.GetLoggedInEmail();
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

            article.isDeleted = true;
            article.DeletedDate = DateTime.UtcNow;
            article.DeletedBy = userEmail;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => x.isDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }

        public async Task<string> UndoDeleteArticleAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

            article.isDeleted = false;
            article.DeletedDate = null;
            article.DeletedBy = null;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }

        public async Task<ArticleListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 8, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(
                a => !a.isDeleted && (a.Title.Contains(keyword) || a.Content.Contains(keyword) || a.Category.Name.Contains(keyword)),
                a => a.Category, i => i.Image, u => u.User);

            var sortedArticles = isAscending
                ? articles.OrderBy(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : articles.OrderByDescending(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new ArticleListDto
            {
                Articles = sortedArticles,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = articles.Count,
                IsAscending = isAscending
            };
        }

        public async Task<List<ArticleDto>> GetLastThreeNonDeletedArticlesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, y => y.Image);

            var lastThreeArticles = articles
                .OrderByDescending(z => z.CreatedDate)
                .Take(3)
                .ToList();

            var articleDtos = mapper.Map<List<ArticleDto>>(lastThreeArticles);
            return articleDtos;
        }

        public async Task<List<ArticleDto>> GetPopularThreeNonDeletedArticlesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, y => y.Image);

            var lastThreeArticles = articles
                .OrderByDescending(z => z.ViewCount)
                .Take(3)
                .ToList();

            var articleDtos = mapper.Map<List<ArticleDto>>(lastThreeArticles);
            return articleDtos;
        }

        public async Task<List<ArticleDto>> GetLastSixNonDeletedArticleImagesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, y => y.Image);

            var lastThreeArticles = articles
                .OrderByDescending(z => z.CreatedDate)
                .Take(6)
                .ToList();

            var articleDtos = mapper.Map<List<ArticleDto>>(lastThreeArticles);
            return articleDtos;
        }

        public async Task<List<ArticleDto>> GetFooterLatestPostsAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, y => y.Image);

            var lastThreeArticles = articles
                .OrderByDescending(z => z.CreatedDate)
                .Take(2)
                .ToList();

            var articleDtos = mapper.Map<List<ArticleDto>>(lastThreeArticles);
            return articleDtos;
        }

        public async Task<List<ArticleDto>> GetFooterPopularPostsAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, y => y.Image);

            var lastThreeArticles = articles
                .OrderByDescending(z => z.ViewCount)
                .Take(2)
                .ToList();

            var articleDtos = mapper.Map<List<ArticleDto>>(lastThreeArticles);
            return articleDtos;
        }

        public async Task<List<ArticleDto>> GetLastTwoNonDeletedArticlesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, y => y.Image, z => z.Category);

            var lastTwoArticles = articles
                .OrderByDescending(z => z.CreatedBy)
                .Take(2)
                .ToList();

            var articleDtos = mapper.Map<List<ArticleDto>>(lastTwoArticles);
            return articleDtos;
        }

        public async Task<List<ArticleDto>> GetLastFourNonDeletedArticlesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, y => y.Image);

            var lastThreeArticles = articles
                .OrderByDescending(z => z.CreatedDate)
                .Take(4)
                .ToList();

            var articleDtos = mapper.Map<List<ArticleDto>>(lastThreeArticles);
            return articleDtos;
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithImagesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, x => x.Image);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
    }
}
