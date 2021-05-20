using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieClient.Pages
{
    public class MovieModel : PageModel
    {
        private readonly ILogger<MovieModel> _logger;

        public MovieModel(ILogger<MovieModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
