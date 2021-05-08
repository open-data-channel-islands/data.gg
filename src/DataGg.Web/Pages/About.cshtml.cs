using DataGg.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web.Pages
{

    //[AllowAnonymous]
    public class AboutModel : BreadcrumPageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public AboutModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;

            Breadcrums.Add(new Breadcrum("About", ""));
        }

        public void OnGet()
        {
        }
    }
}
