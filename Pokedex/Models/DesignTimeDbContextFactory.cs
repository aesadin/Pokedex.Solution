using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Pokedex.Models
{
  public class PokedexContextFactory : IDesignTimeDbContextFactory<PokedexContext>
  {
    PokedexContext IDesignTimeDbContextFactory<PokedexContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();
          
      var builder = new DbContextOptionsBuilder<PokedexContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PokedexContext(builder.Options);
    }
  }
}