using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models
{
    public class Project : IListable
    {
        public Project()
        {
            Images = new List<ProjectImage>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Pdetail { get; set; }

        [Required]
        public virtual ProjectCategory Category { get; set; }

        public virtual ICollection<ProjectImage> Images { get; set; }
    }
}
