using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class FooterLatestPostsViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public FooterLatestPostsViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await articleService.GetFooterLatestPostsAsync();
            return View(result);
        }
    }
}
