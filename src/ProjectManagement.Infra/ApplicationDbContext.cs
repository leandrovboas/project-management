using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProjectManagement.Infra;

public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(IConfiguration configuration, DbContextOptions options): base(options)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));      
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("Portgresql");
        optionsBuilder.UseNpgsql(connectionString);
    }
}
