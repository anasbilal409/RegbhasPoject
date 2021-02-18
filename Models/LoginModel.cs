using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models
{
    public class LoginModel
    {
        public string LoginId { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
