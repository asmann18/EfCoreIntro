using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DAL;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("server=DESKTOP-HQUMO3A\\SQLEXPRESS;database=EfCore;trusted_connection=true;encrypt=false;");
    }

    public DbSet<Student> Students { get; set; }
}
