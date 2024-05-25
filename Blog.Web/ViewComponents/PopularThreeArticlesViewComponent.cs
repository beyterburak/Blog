using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class PopularThreeArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public PopularThreeArticlesViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await articleService.GetPopularThreeNonDeletedArticlesAsync();
            return View(articles);
        }
    }
}
