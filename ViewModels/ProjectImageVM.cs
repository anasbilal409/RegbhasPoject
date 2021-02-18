using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.ViewModels
{
    public class ProjectImageVM
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public byte[] Content { get; set; }

        public int Rank { get; set; }
    }
}
