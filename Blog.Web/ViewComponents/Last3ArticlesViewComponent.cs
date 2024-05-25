using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class Last3ArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public Last3ArticlesViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await articleService.GetLastThreeNonDeletedArticlesAsync();
            return View(articles);
        }

    }
}
