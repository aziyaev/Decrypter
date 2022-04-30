using DecrypterWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace DecrypterWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Input"] = "Ты богат, я очень беден;\nТы прозаик, я поэт;";
            ViewData["Keyword"] = "скорпион";
            return View();
        }


        [HttpPost]
        [ActionName("Index")]
        public IActionResult Index(ResponseData data)
        {
            VigenereCipher vigenereCipher = new VigenereCipher(Alphabet.rus, false, 0);
            
            if(data.Convert == "encode")
                ViewData["Output"] = vigenereCipher.Encode(data.Input, data.Keyword);
            else if(data.Convert == "decode")
                ViewData["Output"] = vigenereCipher.Decode(data.Input, data.Keyword);

            ViewData["Input"] = data.Input;
            ViewData["Keyword"] = data.Keyword;

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