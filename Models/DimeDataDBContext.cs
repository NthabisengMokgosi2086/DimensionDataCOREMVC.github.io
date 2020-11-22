using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace COREMVC.Models
{
    public partial class DimeDataDBContext : DbContext
    {
        public DimeDataDBContext()
        {
        }

        public DimeDataDBContext(DbContextOptions<DimeDataDBContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<EmployeesTable> EmployeesTable { get; set; }
        public virtual DbSet<EmployeesTableExternalData1> EmployeesTableExternalData1 { get; set; }
        public virtual DbSet<HumanResourceTable> HumanResourceTable { get; set; }
        public virtual DbSet<HumanResourceTableExternalData1> HumanResourceTableExternalData1 { get; set; }
        
        public virtual DbSet<ManagerTable> ManagerTable { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1696 // Single-line comment or end-of-line expected after #pragma directive
#pragma warning disable To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server =DESKTOP-6SB3MOH\\SQLEXPRESS; Database =DimeDataDB ;Trusted_Connection=True");
#pragma warning restore CS1696 // Single-line comment or end-of-line expected after #pragma directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<EmployeesTable>(entity =>
            {
                entity.HasKey(x=>x.EmployeeNumber);

                entity.ToTable("Employees_Table$");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.EducationField).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.JobRole).HasMaxLength(255);

                entity.Property(e => e.MaritalStatus).HasMaxLength(255);
            });

            modelBuilder.Entity<EmployeesTableExternalData1>(entity =>
            {
                entity.HasKey(x=>x.EmployeeNumber);

                entity.ToTable("Employees_Table$ExternalData_1");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.EducationField).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.JobRole).HasMaxLength(255);

                entity.Property(e => e.MaritalStatus).HasMaxLength(255);
            });

            modelBuilder.Entity<HumanResourceTable>(entity =>
            {
                entity.HasKey(x=>x.EmployeeNumber);

                entity.ToTable("Human_Resource_Table$");

                entity.Property(e => e.BusinessTravel).HasMaxLength(255);

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.EducationField).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.JobRole).HasMaxLength(255);

                entity.Property(e => e.MaritalStatus).HasMaxLength(255);

                entity.Property(e => e.OverTime).HasMaxLength(255);
            });

            modelBuilder.Entity<HumanResourceTableExternalData1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Human_Resource_Table$ExternalData_1");

                entity.Property(e => e.BusinessTravel).HasMaxLength(255);

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.EducationField).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.JobRole).HasMaxLength(255);

                entity.Property(e => e.MaritalStatus).HasMaxLength(255);

                entity.Property(e => e.OverTime).HasMaxLength(255);
            });

           

            modelBuilder.Entity<ManagerTable>(entity =>
            {
                entity.HasKey(x=>x.EmployeeNumber);

                entity.ToTable("Manager_Table$");

                entity.Property(e => e.Attrition).HasMaxLength(255);

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.JobRole).HasMaxLength(255);

                entity.Property(e => e.OverTime).HasMaxLength(255);
            });

           


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
