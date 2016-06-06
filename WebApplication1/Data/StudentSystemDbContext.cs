using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    class StudentSystemDbContext : DbContext, IStudentSystemDbContext
    {
        public StudentSystemDbContext():base("StudentSystemDBase")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Scholarship> Scholarships { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Subject> Predmets { get; set; }
        public DbSet<SingIn> SingIns { get; set; }
        public DbSet<Facultet> Facultets { get; set; }
        public DbSet<Lecture> Lecturs { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Student> studentLoginAccount { get; set; }


        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }
    }
}
