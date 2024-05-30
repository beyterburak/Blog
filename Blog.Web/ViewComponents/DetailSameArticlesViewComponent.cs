using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class DetailSameArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public DetailSameArticlesViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await articleService.GetLastTwoNonDeletedArticlesAsync();
            return View(articles);
        }
    }
}
