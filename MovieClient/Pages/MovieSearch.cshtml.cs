using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieClient.Pages
{
    public class MovieSearchModel : PageModel
    {
        private readonly ILogger<MovieSearchModel> _logger;

        public MovieSearchModel(ILogger<MovieSearchModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
