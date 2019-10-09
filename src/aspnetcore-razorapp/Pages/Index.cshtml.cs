using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(ILogger<IndexModel> logger, 
            IConfiguration configuration)
        {
            Logger = logger;
            Configuration = configuration;
        }

        private readonly ILogger<IndexModel> Logger;
        private IConfiguration Configuration { get; }
        public string Title { get; private set; }

        public void OnGet()
        {
            Title = string.IsNullOrEmpty(Configuration["TITLE"]) 
                ? "Welcome to ASP.NET Core Razor on Kubernetes" 
                : Configuration["TITLE"];
        }
    }
}
