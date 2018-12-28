using Buycierge.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Buycierge.API.Data
{
    public class DataContext : DbContext
    {
        
        private IConfiguration Configuration { get; }
        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base (options)
        {
            Configuration = configuration;
        }
        
        public DbSet<Value> Values {get;set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }
}