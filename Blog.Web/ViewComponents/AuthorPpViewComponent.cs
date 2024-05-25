using AutoMapper;
using Blog.Entity.DTOs.Users;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class AuthorPpViewComponent : ViewComponent
    {
        private readonly IUserService userService;

        public AuthorPpViewComponent(IUserService userService)
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
