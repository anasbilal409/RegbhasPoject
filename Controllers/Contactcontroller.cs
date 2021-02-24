using Microsoft.AspNetCore.Mvc;
using Regbhas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Controllers
{
    public class Contactcontroller : Controller
    {
        public IActionResult Mail()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Send(Contact contact)
        {
         
            string content = "Name: " + contact.Name;
            content += "<br>Phone " + contact.Phone;
          //  content += "<br>Address " + contact.Address;
            content += "<br>content " + contact.Content;
            if (MailHelper.Send(contact.Email,"anasbilal409@gmail.com",contact.Subject,contact.Content))
            {
                ViewBag.msg = "Success";
            }
            else
            {
                ViewBag.msg = "Error";
            }

            return View();
        }
    }
}
