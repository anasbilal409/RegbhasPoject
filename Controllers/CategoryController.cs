using Microsoft.AspNetCore.Mvc;
using Regbhas.Models;
using Regbhas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult Manage()
        {
            List<ProjectCategoryVM> modelsList = new ProjectHandler().GetTopCategories().ToModel();
            return View(modelsList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("~/views/Category/_Create.cshtml");
        }


        [HttpPost]
        public IActionResult Create(ProjectCategoryVM model)
        {
            new ProjectHandler().AddCategorey(model.ToEntity());
            return RedirectToAction("manage");
        }

        

        [HttpGet]
        public IActionResult Delete(int id)
        {
            ProjectCategory entity = new ProjectHandler().GetCategory(id);

            return PartialView("~/views/Category/_Delete.cshtml", entity.ToModel());
        }


        [HttpPost]
        public IActionResult Delete(ProjectCategoryVM model)
        {
            ProjectCategory entity = new ProjectHandler().DeleteCategory(model.Id);
            return RedirectToAction("manage");
        }
    }
}

