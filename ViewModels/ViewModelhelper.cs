using Microsoft.AspNetCore.Mvc.Rendering;
using Regbhas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.ViewModels
{
    public static class ViewModelhelper
    {
        public static List<SelectListItem> ToSelectListItemList(this IEnumerable<IListable> entities)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var e in entities)
            {
                items.Add(new SelectListItem { Text = e.Name, Value = Convert.ToString(e.Id) });
            }
            items.TrimExcess();
            return items;
        }

        public static ProjectViewModel ToModel(this Project entity)
        {
            ProjectViewModel model = new ProjectViewModel();
            model.Id = entity.Id;
            model.Projectname = entity.Projectname;
            model.Pdetail = entity.Pdetail;


            if (entity.Images != null)
            {
                foreach (var img in entity.Images)
                {
                    model.Images.Add(Convert.ToBase64String(img.Content));
                }
            }
            return model;
        }
        public static Project ToEntity(this ProjectViewModel model)
        {
            return new Project { Id = model.Id, Projectname = model.Projectname  };
        }

        public static List<ProjectViewModel> ToModelsList(this List<Project> entitiesList)
        {
            List<ProjectViewModel> models = new List<ProjectViewModel>();
            foreach (var entity in entitiesList)
            {
                models.Add(entity.ToModel());
            }
            models.TrimExcess();
            return models;
        }
    }
}
