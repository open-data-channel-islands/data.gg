using System;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Core.Types;
using DataGg.Web.Models;
using DataGg.Web.Services;

namespace DataGg.Web.Areas.Developers.Pages;

public class IndexModel : BreadcrumPageModel
{
    private readonly CacheManager _cacheManager;

    public DataCategoryDto DataCategory { get; set; }
    public IndexModel(CacheManager cacheManager)
    {
        Breadcrums.Add(new Breadcrum("Developers", "/Developers"));
        _cacheManager = cacheManager;
    }

    public async Task OnGetAsync(string stub)
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