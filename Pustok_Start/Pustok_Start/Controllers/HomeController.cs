using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_Start.DAL;
using Pustok_Start.Migrations;
using Pustok_Start.Models;
using Pustok_Start.ViewModels; 
using System.Diagnostics;

namespace Pustok_Start.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokDbContext _context;

        public HomeController(PustokDbContext context)
        {
            _context = context;
            
        }
   
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel()
            {
                Sliders = _context.Sliders.ToList(),
                BestSellerBooks=_context.Books.Include(x =>x.Author).Include(x=>x.BookImages).Where(x=>x.IsBestSeller).Take(5).ToList(),
                NewBooks=_context.Books.Include(x => x.Author).Include(x=>x.BookImages).Where(x=>x.IsNew).Take(5).ToList(),
                DiscountBooks=_context.Books.Include(x=>x.Author).Include(x=>x.BookImages).Where(x=>x.DiscountPrice>0).Take(5)?.ToList()

            };
            return View(vm);
        }

        public IActionResult Contact()
        { 
        return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetSession(string key,string value)
        {
            HttpContext.Session.SetString(key, value);
            return RedirectToAction("index");
        }

        public IActionResult GetSession(string Key)
        {
            var value= HttpContext.Session.GetString(Key);
            return Content(value);
        }

        public IActionResult SetCookie(string key,string value)
        {
            HttpContext.Response.Cookies.Append(key, value);
            return Content("");
        }


        public IActionResult GetCookie(string key)
        {
            var value = HttpContext.Request.Cookies[key];
            return Content(value);
        }

    }
}