using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Core.Types;
using DataGg.Database;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataGg.Web.Areas.Developers.Pages
{
    public class IndexModel : BreadcrumPageModel
    {
        private readonly CacheManager _cacheManager;

        public DataCategoryDto DataCategory { get; set; }
        public IndexModel(CacheManager cacheManager)
        {
            Breadcrums.Add(new Breadcrum("Developers", "/Developers"));
            _cacheManager = cacheManager;
        }

        public async void OnGetAsync(string stub)
        {
            Breadcrums.Add(new Breadcrum(stub, $"/Developers/{stub}"));

            var dataCategories = await _cacheManager.DataCategories.Get();

            var stubDataCategory = dataCategories
                .FirstOrDefault(dc => dc.Stub.Equals(stub, StringComparison.OrdinalIgnoreCase));

            if (stubDataCategory != null)
            {
                DataCategory = stubDataCategory;
            }
        }

    }
}
