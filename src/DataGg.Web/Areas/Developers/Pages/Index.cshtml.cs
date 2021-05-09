using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataGg.Web.Areas.Developers.Pages
{
    public class IndexModel : BreadcrumPageModel
    {
        public IndexModel()
        {
            Breadcrums.Add(new Breadcrum("Developers", "/Developers"));
        }

        public async void OnGetAsync(string stub)
        {
            Breadcrums.Add(new Breadcrum(stub, $"/Developers/{stub}"));
        }

    }
}
