using Microsoft.AspNetCore.Mvc;
using Regbhas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Regbhas.Controllers
{
    public class Contactus : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       

        [HttpPost]
        public IActionResult Send(Contact contact)
        {

            string content = "Name: " + contact.Name;
            content += "<br>Phone " + contact.Phone;
           
            content += "<br>content " + contact.Content;
            if (MailHelper.Send(contact.Email, "anasbilal409@gmail.com", contact.Subject, contact.Content))
            {
                ViewBag.msg = "Success";
            }
            else
            {
                ViewBag.msg = "Error";
            }

            return View("Index");
        }

        public IActionResult SendEmail( Contact contact)
        {

            try
            {
                
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 25,
                    EnableSsl = false
                };
                client.Credentials = new NetworkCredential("mail.evslearning.com", "lahore-349");

                MailMessage mailMessage = new MailMessage();
                mailMessage.IsBodyHtml = true;
                mailMessage.From = new MailAddress("website@evslearning.com");
               // mailMessage.ReplyToList.Add(new MailAddress("website@evslearning.com"));
                mailMessage.Subject = "send message";
                mailMessage.Body = "A message from console";
                mailMessage.To.Add("evs1@evslearning.com");

                Console.WriteLine("done");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
    }
}

