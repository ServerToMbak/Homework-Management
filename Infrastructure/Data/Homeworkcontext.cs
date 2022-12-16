using System.Reflection;
using Core.Entites;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Homeworkcontext : DbContext
    {
        public Homeworkcontext(DbContextOptions<Homeworkcontext> options) : base(options)
        {
        }


        public DbSet<Homework> Homeworks { get; set; }
         public DbSet<Student> Students { get; set; }
         public DbSet<Teacher> Teachers { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
         
    }
}