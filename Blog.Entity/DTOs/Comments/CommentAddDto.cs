using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Comments
{
    public class CommentAddDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }

        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
