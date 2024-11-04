using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebApplication1.Pages
{
    public class CountryModel : PageModel
    {
        private readonly ILogger<CountryModel> _logger;

        public string CountryMessage { get; set; }
        public List<Country> Countries { get; set; } = new List<Country>();

        public CountryModel(ILogger<CountryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CountryMessage = "Press button to see countries";
        }

        public void OnPost()
        {
            Countries = new List<Country>
            {
                new Country { Name = "Ukraine", Capital = "Kyiv", Population = 41000000 },
                new Country { Name = "Poland", Capital = "Warsaw", Population = 38300000 },
                new Country { Name = "Moldova", Capital = "Chișinău", Population = 2650000 }
            };
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public long Population { get; set; }
    }
}
