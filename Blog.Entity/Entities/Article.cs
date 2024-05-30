using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class Article : EntityBase
    {
        public Article()
        {
            
        }
        public Article(string title, string content, Guid userId, Guid categoryId, Guid imageId, string createdBy)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
            ImageId = imageId;
            CreatedBy = createdBy;
        }
        public string Title { get; set; }
        public string Content { get; set; }

        public string? Quote { get; set; }
        public string? QuoteAuthor { get; set; }

        public string? VideoUrl { get; set; }
        public string? VideoContent { get; set; }

        public int ViewCount { get; set; } = 0;

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

        public List<Comment> Comments { get; set; }
        public ICollection<ArticleVisitor> ArticleVisitors { get; set; }
    }
}
