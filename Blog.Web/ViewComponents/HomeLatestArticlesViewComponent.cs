using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class HomeLatestArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService _articleService;

        public HomeLatestArticlesViewComponent(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var articles = await _articleService.GetAllArticlesWithImagesAsync();
            return View(articles);
        }
    }
}
