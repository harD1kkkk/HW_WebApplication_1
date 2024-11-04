using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //public string Weather { get; set; }
        public string CurrentTime { get; set; }
        public DateTime now;

        public void OnGet()
        {
            CurrentTime = "Press button to see current Date";
            //Weather = "Press button to see current weather";
            //Weather = "Sunny";
        }
        public void OnPost()
        {
            now = DateTime.Now;
            //List<string> weatherList = new List<string> { "Sunny", "Cloudy", "Rainy", "Stormy", "Snowy" };
            //Random random = new Random();
            //Weather = weatherList[random.Next(weatherList.Count)];
        }
    }
}
