using Microsoft.EntityFrameworkCore;
using UserAuth.Models.Domains;

namespace UserAuth.Data;

public class AppDbContext  : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) {}
    
    public DbSet<User> Users { get; set; }
}