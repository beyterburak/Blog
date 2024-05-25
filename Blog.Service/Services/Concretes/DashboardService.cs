using Blog.Data.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concretes
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork unitOfWork;

        public DashboardService(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<int>> GetYearlyArticleCountsAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted);

            var startDate = DateTime.Now.Date;
            startDate = new DateTime(startDate.Year, 1, 1);

            List<int> datas = new();

            for (int i = 1; i <= 12; i++)
            {
                var startedDate = new DateTime(startDate.Year, i, 1);
                var endedDate = startedDate.AddMonths(1);
                var data = articles.Where(x => x.CreatedDate >= startedDate && x.CreatedDate < endedDate).Count();
                datas.Add(data);
            }

            return datas;
        }
        public async Task<int> GetTotalArticleCountAsync()
        {
            var articleCount = await unitOfWork.GetRepository<Article>().CountAsync(x => !x.isDeleted);

            return articleCount;
        }
        public async Task<int> GetTotalCategoryCountAsync()
        {
            var categoryCount = await unitOfWork.GetRepository<Category>().CountAsync(x => !x.isDeleted);

            return categoryCount;
        }
        public async Task<int> GetTotalUserCountAsync()
        {
            var userCount = await unitOfWork.GetRepository<AppUser>().CountAsync();

            return userCount;
        }

        public async Task<int> GetTotalViewCountAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
            var viewCount = articles.Where(x => !x.isDeleted).Sum(x => x.ViewCount);

            return viewCount;
        }
    }
}
