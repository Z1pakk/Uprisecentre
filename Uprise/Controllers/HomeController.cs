using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Uprise.ActionFilters;
using Uprise.Models;

namespace Uprise.Controllers
{
    [Internationalization]
    public class HomeController : MyController
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
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult ChangeLanguage(string lang)
        //{
        //    new LanguageMang().SetLanguage(lang);
        //    return Redirect(Request.UrlReferrer.ToString());
        //}

        [HttpPost]
        public JsonResult SendMessage(SendMessageViewModel model)
        {
            try
            {
                MailMessage mailMessage = new MailMessage()
                {
                    Subject = model.Subject,
                    Body = "Повідомлення від:" + model.FullName+"("+model.Email+")" + "<br /> Текст повідомлення:" + model.TextMessage,
                    IsBodyHtml = true
                };
                mailMessage.To.Add("uprisecenter@gmail.com");
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Send(mailMessage);
                return Json(new { Status = 1, Text = "Ви успішно відправили повідомлення.Чекайте відповіді на своїй пошті" }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { Status = 0, Text = "Виникла помилка.Текст помилки:"+ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Courses()
        {

            return View();
        }
        public ActionResult English()
        {

            return View();
        }
        public ActionResult ProgADesign()
        {

            return View();
        }
        public ActionResult PreparToSchool()
        {

            return View();
        }
        public ActionResult ArtSchool()
        {

            return View();
        }
        public ActionResult Smartkidsclub()
        {

            return View();
        }
        //public ActionResult News()
        //{
        //    ViewBag.Message = "English";

        //    return View();
        //}
    }
}