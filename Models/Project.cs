using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models
{
    public class Project
    {
        public Project()
        {
            Images = new List<ProjectImage>();
        }

        public int Id { get; set; }

        public string Projectname { get; set; }

        public string Pdetail { get; set; }

        public virtual ICollection<ProjectImage> Images { get; set; }
    }
}
