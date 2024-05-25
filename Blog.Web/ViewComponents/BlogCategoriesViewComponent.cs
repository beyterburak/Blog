using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class BlogCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public BlogCategoriesViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.GetAllCategoriesNonDeletedTakeSomeAsync(10);
            return View(categories);
        }

    }
}
