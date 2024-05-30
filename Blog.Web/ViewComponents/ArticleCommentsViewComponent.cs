using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class ArticleCommentsViewComponent : ViewComponent
    {
        private readonly ICommentService commentService;

        public ArticleCommentsViewComponent(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(Guid id)
        {
            var values = await commentService.GetArticleByIdAsync(id);
            return View(values);
        }
    }
}
