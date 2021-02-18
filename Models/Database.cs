using Microsoft.EntityFrameworkCore;
using Regbhas.Models.UserMgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=MRRMEHAR; Initial Catalog=RegbhasCore; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<User>()
            // .HasOne<Role>(u => u.Role)


            //.WithMany();


            // modelBuilder.Entity<Product>()
            //.cas


            //1 to 1


            modelBuilder.Entity<Project>()
                .HasMany<ProjectImage>(a => a.Images)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

           

            

            

            //modelBuilder.Entity<Advertizement>()
            //    .HasOne<User>(a => a.PostedBy)
            //    .WithMany()
            //    .OnDelete(DeleteBehavior.SetNull);




        }

        public DbSet<Userregistration> UserRegistration { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Project> Project { get; set; }
      
    }

}
