using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataGg.Web.Areas.Charts.Pages
{
    public class BusesModel : BreadcrumPageModel
    {
        public BusesModel()
        {
            Breadcrums.Add(new Breadcrum("Charts", "/Charts"));
        }

        public void OnGet()
        {
            Breadcrums.Add(new Breadcrum("Buses", $"/Charts/Buses"));
        }
    }
}
