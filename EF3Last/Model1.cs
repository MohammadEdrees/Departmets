namespace EF3Last
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DepId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.title)
                .IsUnicode(false);
        }
    }
}
