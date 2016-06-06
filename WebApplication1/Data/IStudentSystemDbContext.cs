using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    interface IStudentSystemDbContext
    {
        DbSet<Facultet> Facultets { get; set; }
        DbSet<Inspector> Inspectors { get; set; }
        DbSet<Lecture> Lecturs { get; set; }
        DbSet<Subject> Predmets { get; set; }
        DbSet<Scholarship> Scholarships { get; set; }
        DbSet<SingIn> SingIns { get; set; }
        DbSet<Specialty> Specialties { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Student> studentLoginAccount { get; set; }


        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

    }
}