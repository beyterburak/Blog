using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class LastSixArticleImagesViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public LastSixArticleImagesViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await articleService.GetLastSixNonDeletedArticleImagesAsync();
            return View(articles);
        }
    }
}
