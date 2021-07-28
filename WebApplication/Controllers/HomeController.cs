using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using System.Net;
using System.Net.Mail;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        [HttpPost]
        public ActionResult Contact(ContactFormModel contactForm)
        {


            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("harrydinmore95@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587; 
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; 
            smtp.UseDefaultCredentials = false; 
            smtp.Credentials = new NetworkCredential(mail.From.Address, "qxardvgfpvwurbun");  
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress("support@titanwebtech.co.uk"));

            mail.IsBodyHtml = true;
            string st = contactForm.Name + contactForm.Subject + contactForm.Query + contactForm.Email;

            mail.Body = st;
            smtp.Send(mail);

            return Content("Thanks for contacting us! We'll be in contact with you soon!");
        }

    }
}
