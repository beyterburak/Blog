using AutoMapper;
using Blog.Entity.DTOs.Users;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.ViewComponents
{
    public class DashboardHeaderPpViewComponent : ViewComponent
    {
        private readonly IUserService userService;

        public DashboardHeaderPpViewComponent(IUserService userService)
        {
            this.userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await userService.GetUserProfileAsync();
            return View(result);
        }
    }
}
