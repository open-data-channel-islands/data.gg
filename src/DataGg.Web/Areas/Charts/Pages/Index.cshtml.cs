using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataGg.Web.Areas.Charts.Pages
{
    public class IndexModel : BreadcrumPageModel
    {
        public IndexModel()
        {
            Breadcrums.Add(new Breadcrum("Charts", "/Charts"));

        }
        public async void OnGetAsync(string stub)
        {
            Breadcrums.Add(new Breadcrum(stub, $"/Charts/{stub}"));
        }

    }
}
