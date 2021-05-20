using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MovieClient.Pages
{
    public class UpdateMovie : PageModel
    {
        private readonly ILogger<UpdateMovie> _logger;

        public UpdateMovie(ILogger<UpdateMovie> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
