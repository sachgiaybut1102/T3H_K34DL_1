using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAppMVC5.Models.EF;

namespace WebAppMVC5.Controllers
{
    public class SendMailController : Controller
    {
        // GET: SendMail
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(MailInfo mailInfo)
        {
            string msg = "";

            if (mailInfo != null)
            {
                try
                {
                    //Mail configuration
                    var mail = new SmtpClient("smtp.gmail.com", 25)
                    {
                        Credentials = new NetworkCredential("t3heducation@gmail.com", "T3h@123123"),
                        EnableSsl = true
                    };

                    //Mail data
                    var message = new MailMessage();
                    message.From = new MailAddress("t3heducation@gmail.com");
                    message.To.Add(mailInfo.To);
                    message.Subject = mailInfo.Subject;
                    message.Body = mailInfo.Note;

                    //send mail
                    await mail.SendMailAsync(message);

                    ViewBag.Success = "Gửi mail thành công!";

                    return View();
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }
            }

            ViewBag.Error = "Có lỗi xảy ra, vui lòng kiểm tra lại \n" + msg;

            return View(mailInfo);
        }
    }
}