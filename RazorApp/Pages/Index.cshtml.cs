﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var url = Url.RouteUrl("./Error", new { User="abcd",code="adasdas"});
            var thee = url;
        }
    }
}