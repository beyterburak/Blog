using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class HomeLastSixArticleImagesViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public HomeLastSixArticleImagesViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var images = await articleService.GetLastSixNonDeletedArticleImagesAsync();
            return View(images);
        }
    }
}
