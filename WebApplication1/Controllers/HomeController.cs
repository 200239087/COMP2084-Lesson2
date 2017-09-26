using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return base.View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return base.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return base.View();
        }

        public ActionResult Store()
        {

            return View();
        }
    }
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>();

            for (int i = 1; i <= 10; i++)
            {
                genres.Add(new Genre { Name = "Genre " + i.ToString() });
            }

            // ViewBag.genres = genres;
            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            // add selected genre to the viewbag
            ViewBag.genre = genre;
            return View();
        }
    }
}