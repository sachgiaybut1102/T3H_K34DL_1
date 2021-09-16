using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC5.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SayHello()
        {
            ViewBag.Msg = "Đấy tin nhắn từ Action lưu trong ViewBag";
            ViewData["Msg2"] = "Đây là tin nhắn từ Action lưu trong ViewData";

            return View();
        }
    }
}