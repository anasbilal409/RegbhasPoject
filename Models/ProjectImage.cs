using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models
{
    public class ProjectImage
    {
        public int Id { get; set; }

       

        [Column(TypeName = "varchar(100)")]
        public string Caption { get; set; }

        [Required]
        [Column(TypeName = "image")]
        public byte[] Content { get; set; }



        public int Rank { get; set; }

      
    }
}
