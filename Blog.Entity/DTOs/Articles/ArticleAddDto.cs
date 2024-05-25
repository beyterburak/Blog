using Blog.Entity.DTOs.Categories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string? Quote { get; set; }
        public string? QuoteAuthor { get; set; }

        public string? VideoUrl { get; set; }
        public string? VideoContent { get; set; }

        public Guid CategoryId { get; set; }

        public IFormFile Photo { get; set; }
        
        public IList<CategoryDto> Categories { get; set; }
    }
}
