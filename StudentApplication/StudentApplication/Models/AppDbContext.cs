using System;
using Microsoft.EntityFrameworkCore;

namespace StudentApplication.Models
{
    public class AppDbContext : DbContext //From entity framework core
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        //Asiking Entity core to manage the Student Entity to manage in the database 
        public DbSet<Student> Students { get; set; }

        //Later it will create a Student table in the database
    }
}
