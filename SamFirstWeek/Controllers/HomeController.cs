using Microsoft.AspNetCore.Mvc;
using SamFirstWeek.DataReader;
using SamFirstWeek.Models;
using System.Diagnostics;


namespace SamFirstWeek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public string BasicPath = "";
        public string DeluxPath = "";
        public string TotalPath = "";

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            BasicPath = _configuration["TxtPath:Basic"];
            DeluxPath = _configuration["TxtPath:Delux"];
            TotalPath = _configuration["TxtPath:Total"];
        }

        public IActionResult Index()
        {
            HomeViewModel homeView = new HomeViewModel();
            homeView.basic = DataReaderFile.CreateListReverseAndAddDate(DataReaderFile.GetT(BasicPath));
            homeView.delux = DataReaderFile.CreateListReverseAndAddDate(DataReaderFile.GetT(DeluxPath));
            homeView.total = DataReaderFile.CreateListReverseAndAddDate(DataReaderFile.GetT(TotalPath));


            return View(homeView);
        }



           

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}