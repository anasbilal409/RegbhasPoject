using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models.UserMgt
{
    public class UsersHandler
    {
        public Userregistration GetUser(string loginid, string password)
        {
            using (Database context = new Database())
            {
                return (from u in context.UserRegistration
                        .Include("Role")

                        where u.LoginId.Equals(loginid) && u.Password.Equals(password)
                        select u).FirstOrDefault();
            }
        }

       
    }
}
