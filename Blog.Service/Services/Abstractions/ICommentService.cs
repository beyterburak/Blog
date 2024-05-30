using Blog.Entity.DTOs.Comments;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface ICommentService
    {
        Task<List<CommentDto>> GetArticleByIdAsync(Guid id);
        Task AddCommentAsync(CommentAddDto commentAddDto);
    }
}
