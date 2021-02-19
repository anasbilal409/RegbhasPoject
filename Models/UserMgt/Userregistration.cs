using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models.UserMgt
{
    public class Userregistration
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string LoginId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required]
        public virtual Role Role { get; set; }
    }
}
