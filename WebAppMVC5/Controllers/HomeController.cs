using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC5.Models.EF;

namespace WebAppMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Trả về một chuỗi
        public ActionResult TextPlain()
        {
            return Content("Đây là kết quả của Content");
        }

        //Trả về nội dung của File
        public ActionResult FileContent()
        {
            return File("~/Global.asax.cs", "text/plain");
        }

        //Trả về dữ liệu Json
        public ActionResult JsonContent()
        {
            List<MailInfo> mailInfos = new List<MailInfo>();
            mailInfos.Add(new MailInfo() { To = "minhsaothe1102@gmail.com", Subject = "Tiêu đề 1", Note = "Nội dung là TestJson" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 2", Note = "Nội dung là TestJson" });

            return Json(mailInfos, JsonRequestBehavior.AllowGet);
        }

        //Chia sẻ dữ liệu từ Controller sang View
        public ActionResult Mail()
        {
            List<MailInfo> mailInfos = new List<MailInfo>();
            mailInfos.Add(new MailInfo() { To = "minhsaothe1102@gmail.com", Subject = "Tiêu đề 1", Note = "Nội dung là TestJson1" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 2", Note = "Nội dung là TestJson2" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 3", Note = "Nội dung là TestJson3" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 4", Note = "Nội dung là TestJson4" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 5", Note = "Nội dung là TestJson5" });

            return View(mailInfos);
        }

        public ActionResult Helper()
        {
            List<MailInfo> mailInfos = new List<MailInfo>();
            mailInfos.Add(new MailInfo() { To = "minhsaothe1102@gmail.com", Subject = "Tiêu đề 1", Note = "Nội dung là TestJson1" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 2", Note = "Nội dung là TestJson2" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 3", Note = "Nội dung là TestJson3" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 4", Note = "Nội dung là TestJson4" });
            mailInfos.Add(new MailInfo() { To = "sachigaybut1103@gmail.com", Subject = "Tiêu đề 5", Note = "Nội dung là TestJson5" });

            ViewBag.MailInfos = new SelectList(mailInfos, "To", "To");

            return View();
        }

        public ActionResult StudentRegister()
        {
            ViewBag.Gender = new SelectList(new[] {
                new { Name = "Nam", Value = true },
                new { Name = "Nữ", Value = false }
            }, "Value", "Name");

            return View(new Student() { DateOfBirth = new DateTime() });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StudentRegister(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Success = "Tạo thành công";
            }

            ViewBag.Gender = new SelectList(new[] {
                new { Name = "Nam", Value = true },
                new { Name = "Nữ", Value = false }
            }, "Value", "Name", student.Gender);

            return View(student);
        }

        public ActionResult TestJQuery()
        {
            return View();
        }
    }
}