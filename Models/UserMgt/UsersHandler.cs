using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models.UserMgt
{
    public class UsersHandler
    {
        public List<Userregistration> GetUsers()
        {
            using (Database context = new Database())
            {
                return (from u in context.UserRegistration
                        .Include("Role")
                        select u).ToList();
            }
        }
    }
}
