using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using TodoConsoleApp.Models;

namespace TodoConsoleApp
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DFECLI5;Initial Catalog=Training_Session;User ID = sa; Password = a ;TrustServerCertificate=True; ");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Employee> Employees { get; set; }
        //public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ToTable used to configure tablename
            //  modelBuilder.Entity<Department>().ToTable("Dept");

            //haskey used to configure the primary key
            //modelBuilder.Entity<Department>().HasKey(d=>d.DeptId);

            //properties configuration for employee table
            //modelBuilder.Entity<Employee>().Property(emp => emp.EmployeeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);//used to set autoincrement false
            modelBuilder.Entity<Employee>().Property(emp => emp.Name).HasColumnName("EmpName")// used to configure the columnName
           .IsRequired()// used to configure non nullable
           .HasMaxLength(100)
           .HasColumnType("nvarchar");
            //base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<Employee>().Property(emp => emp.Phone).IsOPtional();
            modelBuilder.Entity<Employee>().Property(emp => emp.Phone).IsRequired();
            modelBuilder.Entity<Address>().HasKey(emp => emp.EmployeeId);
            //one to one relationship between employee and employeeAddress
            modelBuilder.Entity<Employee>().HasOne(a => a.Address);
            //.WillCascadeOnDelete(false);

            //one to may relationship between employee and department
            //modelBuilder.Entity<Department>().HasMany(d=>d.Employees)

        }
    }
}
