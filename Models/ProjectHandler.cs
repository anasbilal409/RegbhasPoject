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


                        select c).ToList();
            }
        }


        public void AddProject(Project adv)
        {
            using (Database context = new Database())
            {

                context.Add(adv);
                context.SaveChanges();
            }
        }
    }
}
