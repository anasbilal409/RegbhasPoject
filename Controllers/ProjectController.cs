using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IActionResult PostProject()
        {
            ProjectViewModel model = new ProjectViewModel();
            List<SelectListItem> topCategories = new List<SelectListItem> { new SelectListItem { Text = "Select Category", Value = "0" } };
            topCategories.AddRange(new ProjectHandler().GetTopCategories().ToSelectListItemList());
            model.TopLevelCategories = topCategories;

            return PartialView("~/views/Project/_PostProject.cshtml", model);
        }

        [HttpPost]
        public IActionResult PostProject(ProjectViewModel model)
        {

            model.Category = new ProjectCategoryVM { Id = Convert.ToInt32(Request.Form["categories"]) };
           
            Project entity = model.ToEntity();
            int counter = -1;

            string[] captionArray = Request.Form["phcaption"];
            foreach (var file in Request.Form.Files)
            {
                if (!string.IsNullOrWhiteSpace(file.FileName))
                {
                    ProjectImage imgModel = new ProjectImage { Rank = ++counter };
                    imgModel.Caption = captionArray[counter];
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


        public IActionResult Details(int id)
        {
            ProjectViewModel m = new ProjectHandler().GetProject(id).ToModel();
           // List<ProjectImage> lists = new ProjectHandler().GetAfterPics();
            //List<ProjectImage> list = new ProjectHandler().GetBeforePics();
            return PartialView("~/Views/Project/_Details.cshtml", m);
        }

    }
}
