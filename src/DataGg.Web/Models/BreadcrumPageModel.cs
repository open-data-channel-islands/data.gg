using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web.Models
{
    public class BreadcrumPageModel : PageModel
    {
        public readonly List<Breadcrum> Breadcrums = new List<Breadcrum>() { new Breadcrum("Home", "/") };


    }

    public class Breadcrum
    {
        public Breadcrum(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public string Name { get; set; }
        public string Url { get; set; }
    }
}
