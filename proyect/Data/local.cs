using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace proyect.Data
{
    public class local: DbContext 
    {
        public local(DbContextOptions<local> options): base(options) 
        {
            

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<local>().ToCollection("Doctores");

        //}

        public DbSet<t001_doctor> t001_doctor { get; set; }
    }
}
