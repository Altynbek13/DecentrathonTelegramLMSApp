using Application.Models;
using AutoMapper;
using DecentrathonTelegramLMSApp.MVC.Models;
using Domain.Entities;
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
        private readonly ITelegramBotClient _telegramBotClient;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, UserMockRepository userMockRepository, ITelegramBotClient telegramBotClient, IMapper mapper)
        {
            _logger = logger;
            _userMockRepository = userMockRepository;
            _telegramBotClient = telegramBotClient;
            _mapper = mapper;
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

        public async Task<IActionResult> Profile()
        {
            
            var myName = (await _telegramBotClient.GetMeAsync()).Username;
            var user = _userMockRepository.Users.FirstOrDefault(u => u.Username == myName);
            var userViewModel = _mapper.Map<Domain.Entities.User,UserViewModel>(user);
            return View(userViewModel);
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
