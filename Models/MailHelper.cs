using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Regbhas.Models
{
    public class MailHelper
    {
       
        public static bool Send(string fromAddress,string toAddress,string subject, string content) 


        {
            try {
                var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsetting.json");
                var configuration = builder.Build();
                var host = configuration["Gmail:Host"];
                var port = int.Parse(configuration["Gmail:port"]);
                var username = configuration["Gmail:username"];
                var password = configuration["Gmail:Password"];
                var enable = bool.Parse(configuration["Gmail:SMTP:startls:enable)"]);

                var smtpClient = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("anasbilal409@gmail.com", "sa18226@gmail.com")


                };
                var message = new MailMessage(fromAddress, toAddress);
                message.Subject = subject;
                message.Body = content;
                message.IsBodyHtml = true;
                smtpClient.Send(message);
                return true;
            }
            catch 
            {
                return false;
            }
            
        }
            


    }
}
