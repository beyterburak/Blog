using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Blog.Entity.Entities
{
    public class Comment : EntityBase
    {
        public Comment() { }
        public Comment(string content, Guid articleId, string email, string username) 
        { 
            Content = content;
            ArticleId = articleId;
            Email = email;
            Username = username;
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }

        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
