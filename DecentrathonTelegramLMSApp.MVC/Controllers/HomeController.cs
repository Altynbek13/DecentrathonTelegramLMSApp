using DecentrathonTelegramLMSApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Persistence.Mocks;
using System.Diagnostics;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DecentrathonTelegramLMSApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserMockRepository _userMockRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lider()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Course()
        {
            return View();
        }
        public IActionResult Tasks()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Quiz()
        {
            return View();
        }
        public IActionResult Quest()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }
        
        public IActionResult Profile(ITelegramBotClient telegramBotClient)
        {
            var user = _userMockRepository.Users.FirstOrDefault(u => u.Username  == telegramBotClient.GetMyNameAsync().Result.Name);
            return View();
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
