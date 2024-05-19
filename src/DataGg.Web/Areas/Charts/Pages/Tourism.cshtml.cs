using DataGg.Web.Models;

namespace DataGg.Web.Areas.Charts.Pages
{
    public class Tourism : BreadcrumPageModel
    {
        public Tourism() {
            Breadcrums.Add(new Breadcrum("Charts", "/Charts"));
            Breadcrums.Add(new Breadcrum("Tourism", "/Charts/Tourism"));
        }

        public void OnGet()
        {
            
        }
    }
}
