using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models.UserMgt
{
    public class Userregistration
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public virtual Role Role { get; set; }
    }
}
