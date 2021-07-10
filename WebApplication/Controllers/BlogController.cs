using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public ActionResult List()
        {
            var model = new List<BlogItem>()
            {
                new BlogItem { Title = "Blog Item 1", DateCreated = new DateTime(2021,01,15), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 2", DateCreated = new DateTime(2021,02,12), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 3", DateCreated = new DateTime(2021,01,02), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 4", DateCreated = new DateTime(2021,07,01), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 5", DateCreated = new DateTime(2020,12,27), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 6", DateCreated = new DateTime(2020,11,11), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 7", DateCreated = new DateTime(2021,03,15), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 8", DateCreated = new DateTime(2020,11,03), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 9", DateCreated = new DateTime(2020,08,15), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."},
                new BlogItem { Title = "Blog Item 10", DateCreated = new DateTime(2020,10,16), Description = "Donec sollicitudin molestie malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Nulla porttitor accumsan tincidunt. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem."}
            };

            return View(model);
        }
     

    }
}
