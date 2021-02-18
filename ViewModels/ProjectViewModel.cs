using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel()
        {

            Images = new List<string>();

        }

        public int Id { get; set; }

        public string Projectname { get; set; }

        public string Pdetail { get; set; }

        public List<string> Images { get; set; }
    }
}
