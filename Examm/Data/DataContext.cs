using Examm.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Examm.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Location> Locations { get; set; }


    }
}
