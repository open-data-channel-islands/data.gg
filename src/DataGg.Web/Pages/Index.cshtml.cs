using DataGg.Core.Types;
using DataGg.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web.Pages;

public class IndexModel : PageModel
{
    private readonly CacheManager _cacheManager;
    public DataSetDto[] LastUpdated { get; set; } = [];

    public IndexModel(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task OnGetAsync()
    {
        if (_cacheManager.DataCategories.IsCached)
        {
            LastUpdated = (await _cacheManager.DataCategories.Get())
                .SelectMany(dc => dc.DataSets)
                .Where(dc => dc.CurrentDataJson is not null)
                .OrderByDescending(ds => ds.CurrentDataJson.Stamp)
                .Take(10)
                .ToArray();
        }
    }
}