﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IDashboardService
    {
        Task<List<int>> GetYearlyArticleCountsAsync();
        Task<int> GetTotalArticleCountAsync();
        Task<int> GetTotalCategoryCountAsync();
        Task<int> GetTotalUserCountAsync();
        Task<int> GetTotalViewCountAsync();
    }
}
