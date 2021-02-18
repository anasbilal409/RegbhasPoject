using Microsoft.AspNetCore.Mvc;
using Regbhas.Models;
using Regbhas.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Manage()
        {
            List<ProjectViewModel> models = new ProjectHandler().GetProjects().ToModelsList();
            return View(models);
        }

        [HttpGet]
        public IActionResult PostProduct()
        {

            return View();
        }

        [HttpPost]
        public IActionResult PostProduct(ProjectViewModel model)
        {



            Project entity = model.ToEntity();
            int counter = -1;
            foreach (var file in Request.Form.Files)
            {
                if (!string.IsNullOrWhiteSpace(file.FileName))
                {
                    ProjectImage imgModel = new ProjectImage { Rank = ++counter };
                    int fileSize = (int)file.Length;
                    using (MemoryStream ms = new MemoryStream(fileSize))
                    {
                        file.CopyTo(ms);
                        imgModel.Content = ms.ToArray();
                    }
                    entity.Images.Add(imgModel);
                }
            }
            new ProjectHandler().AddProject(entity);

            return RedirectToAction("manage");
        }


        //public IActionResult Details(int id)
        //{
        //    ProductViewModel m = new ProductsHandler().GetProduct(id).ToModel();
        //    return PartialView("~/Views/Products/_Details.cshtml", m);
        //}

    }
}
