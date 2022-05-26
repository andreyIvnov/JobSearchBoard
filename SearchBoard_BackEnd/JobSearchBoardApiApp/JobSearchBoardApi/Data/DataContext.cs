using JobSearchBoardApi.Models;
using Microsoft.EntityFrameworkCore;    //Instaled by Microsoft.EntityFrameworkCore nuget

namespace JobSearchBoardApi.Data
{
    public class DataContext    : DbContext   
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<Company> Companies{ get; set; }
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<IndastryType> IndastryTypes { get; set;}
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }   
    }
}
