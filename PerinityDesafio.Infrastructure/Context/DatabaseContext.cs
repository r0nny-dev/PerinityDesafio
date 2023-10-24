using Microsoft.EntityFrameworkCore;
using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Infrastructure.Context;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<PersonRegister> Persons { get; set; }
    public DbSet<TaskRegister> TaskRegisters { get; set; }
    public DbSet<DepartmentRegister> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<DepartmentRegister>()
            .HasKey(dp => dp.Id);

        modelBuilder.Entity<PersonRegister>()
            .HasKey(ps => ps.Id);

        modelBuilder.Entity<TaskRegister>()
            .HasKey(tk => tk.Id);

        modelBuilder.Entity<PersonRegister>()
           .HasOne(ps => ps.DepartmentRegister)
           .WithMany(dp => dp.PersonRegisters)
           .HasForeignKey(ps => ps.DepartmentRegisterId);

        modelBuilder.Entity<TaskRegister>()
            .HasOne(tk => tk.PersonRegister)
            .WithMany(ps => ps.TaskRegisters)
            .HasForeignKey(tk => tk.PersonRegisterId)
            .IsRequired(false);

        modelBuilder.Entity<TaskRegister>()
            .HasOne(tk => tk.DepartmentRegister)
            .WithMany(dp => dp.TaskRegisters)
            .HasForeignKey(tk => tk.DepartmentRegisterId);

    }
}
