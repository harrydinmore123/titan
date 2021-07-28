using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace WebApplication.Controllers
{
    public class ContactController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

