using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class FooterPopularPostsViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public FooterPopularPostsViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await articleService.GetFooterPopularPostsAsync();
            return View(result);
        }
    }
}
