using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public partial class PepeHubDbContext : DbContext
{
    private readonly IConfiguration Configuration;

    public PepeHubDbContext()
    {
    }

    public PepeHubDbContext(DbContextOptions<PepeHubDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Pepe> Pepes { get; set; }
    public virtual DbSet<PepeVote> PepeVotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connection = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var connectionString = connection.GetConnectionString("PepeHubDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey("Id");
            entity.Property(e => e.Username);
            entity.Property(e => e.Email);
            entity.Property(e => e.Avatar);
            entity.Property(e => e.Bio);
            entity.Property(e => e.Password);
        });

        modelBuilder.Entity<Pepe>(entity =>
        {
           entity.HasKey("Id");
           entity.Property(e => e.Title); 
           entity.Property(e => e.Content); 
           entity.Property(e => e.CreatedAt); 
        });

        modelBuilder.Entity<PepeVote>(entity =>
        {
           entity.HasKey("Id");
           entity.Property(e => e.Vote);
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}