using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataGg.Web.Areas.Charts.Pages
{
    public class Crime : BreadcrumPageModel
    {
        public Crime()
        {
            Breadcrums.Add(new Breadcrum("Charts", "/Charts"));
            Breadcrums.Add(new Breadcrum("Crime", $"/Charts/Crime"));
        }

        public void OnGet()
        {
            
        }
    }
}
