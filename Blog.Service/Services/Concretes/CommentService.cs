using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Comments;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Blog.Service.Services.Concretes
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<CommentDto>> GetArticleByIdAsync(Guid id)
        {
            var comments = await unitOfWork.GetRepository<Comment>().GetAllAsync(x => x.ArticleId == id);
            var commentDtos = mapper.Map<List<CommentDto>>(comments);
            return commentDtos;
        }

        public async Task AddCommentAsync(CommentAddDto commentAddDto)
        {
            var comment = new Comment(commentAddDto.Content, commentAddDto.ArticleId, commentAddDto.Email, commentAddDto.Username);

            await unitOfWork.GetRepository<Comment>().AddAsync(comment);
            await unitOfWork.SaveAsync();
        }
    }
}
