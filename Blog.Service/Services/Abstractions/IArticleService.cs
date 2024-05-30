using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<List<ArticleDto>> GetAllArticlesWithCategoryDeletedAsync();
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
        Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task<string> SafeDeleteArticleAsync(Guid articleId);
        Task<string> UndoDeleteArticleAsync(Guid articleId);
        Task<ArticleListDto> GetAllByPagingAsync(Guid? categoryId, int currentPage = 1, int pageSize = 8, bool isAscending = false);
        Task<ArticleListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 8, bool isAscending = false);
        Task<List<ArticleDto>> GetLastThreeNonDeletedArticlesAsync();
        Task<List<ArticleDto>> GetPopularThreeNonDeletedArticlesAsync();
        Task<List<ArticleDto>> GetLastSixNonDeletedArticleImagesAsync();
        Task<List<ArticleDto>> GetFooterLatestPostsAsync();
        Task<List<ArticleDto>> GetFooterPopularPostsAsync();
        Task<List<ArticleDto>> GetLastTwoNonDeletedArticlesAsync();
        Task<List<ArticleDto>> GetLastFourNonDeletedArticlesAsync();
        Task<List<ArticleDto>> GetAllArticlesWithImagesAsync();
    }
}
