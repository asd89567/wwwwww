using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F411004265.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Indexs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Music(String name, int count)
        {

            ViewBag.Name = name;
            if (count == 1)
            {
                ViewBag.Count = "do";
            }
            else if (count == 2)
            {
                ViewBag.Count = "re";
            }
            else if (count == 3)
            {
                ViewBag.Count = "mi";
            }
            else if (count == 4)
            {
                ViewBag.Count = "fa";
            }
            else if (count == 5)
            {
                ViewBag.Count = "so";
            }
            else if (count == 6)
            {
                ViewBag.Count = "la";
            }
            else if (count == 7)
            {
                ViewBag.Count = "xi";
            }

            else
            {
                ViewBag.Count = "錯誤";
            }
            ViewBag.Count = count;
            return View();
        }
    }
}