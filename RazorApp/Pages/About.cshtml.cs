using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace RazorApp.Pages
{
    public class AboutModel : PageModel
    {
        IConfiguration _config;
        public AboutModel(IConfiguration config)
        {
            _config = config;
        }

        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }

        public async Task OnPost()
        {
            if (ModelState.IsValid)
            {
                if (!await GoogleRecaptchaHelper.IsReCaptchaPassedAsync(Request.Form["g-recaptcha-response"],
                    _config["GoogleReCaptcha:secret"]))
                {
                    ModelState.AddModelError(string.Empty, "You failed the CAPTCHA");
                   
                }
                //do your stuff here...               
            }
            
        }
    }
}
