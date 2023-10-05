using Lappy.Models;
using Lappy.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lappy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        public async Task<IActionResult> Index(string sterm = "", int companyId = 0)
        {
            IEnumerable<LaptopModel> laptops = await _homeRepository.GetLaptops(sterm, companyId);
            IEnumerable<CompanyModel> companies = await _homeRepository.Companies();
            LaptopDisplayModel laptopM = new LaptopDisplayModel
            {
                Laptops = laptops,
                Companies = companies,
                STerm = sterm,
                CompanyId = companyId
            };

            return View(laptopM);
        }

        public IActionResult Privacy()   
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}