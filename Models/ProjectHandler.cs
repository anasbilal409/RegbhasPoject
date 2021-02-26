using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models
{
    public class ProjectHandler
    {

        public List<Project> GetProjects()
        {
            using (Database context = new Database())
            {
                return (from c in context.Project
                          
                           .Include(p => p.Images)
                           .Include(p =>  p.Category)


                        select c).ToList();
            }
        }

      

        public List<ProjectCategory> GetTopCategories()
        {
            using (Database context = new Database())
            {
                return (from ac in context.ProjectCategory
                        
                        select ac).ToList();
            }
        }


        public void AddProject(Project adv)
        {
            using (Database context = new Database())
            {
                context.Entry(adv.Category).State = EntityState.Unchanged;
                context.Add(adv);
                context.SaveChanges();
            }
        }

        public ProjectCategory GetCategory(int id)
        {
            using (Database context = new Database())
            {
                return (from ac in context.ProjectCategory

                        where ac.Id == id
                        select ac).FirstOrDefault();
            }
        }

        public Project GetProject(int id)
        {
            using (Database context = new Database())
            {
                Project found = (from adv in context.Project
                                        .Include(adv => adv.Images)
                                        .Include(adv => adv.Category)
                                 where adv.Id == id 
                                 select adv).FirstOrDefault();
                return found;
            }
        }

        public Project DeleteProduct(int id)
        {
            using (Database context = new Database())
            {
                Project found = (from c in context.Project
                                 where c.Id == id
                                 select c).FirstOrDefault();
                context.Remove(found);
                context.SaveChanges();
                return found;
            }
        }

        public void AddCategorey(ProjectCategory adv)
        {
            using (Database context = new Database())
            {

                context.Add(adv);
                context.SaveChanges();
            }
        }

        public ProjectCategory DeleteCategory(int id)
        {
            using (Database context = new Database())
            {
                ProjectCategory found = (from c in context.ProjectCategory
                                         where c.Id == id
                                         select c).First();
                context.Remove(found);
                context.SaveChanges();
                return found;
            }
        }
    }
}
