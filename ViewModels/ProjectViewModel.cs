using Microsoft.AspNetCore.Mvc.Rendering;
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

        public string Name { get; set; }

        public string Pdetail { get; set; }
        public ProjectCategoryVM Category { get; set; }
        //public List<ProductsImageVM> Images { get; set; }

        public List<SelectListItem> TopLevelCategories { get; set; }

        public List<string> Images { get; set; }
    }
}
