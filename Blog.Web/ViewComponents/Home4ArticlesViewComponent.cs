using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class Home4ArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public Home4ArticlesViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await articleService.GetLastFourNonDeletedArticlesAsync();
            return View(articles);
        }
    }
}
