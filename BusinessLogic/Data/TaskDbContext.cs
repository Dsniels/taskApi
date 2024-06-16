using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace BusinessLogic.Data;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base( options ){}

    public DbSet<Tasks> Tasks {get; set;}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
