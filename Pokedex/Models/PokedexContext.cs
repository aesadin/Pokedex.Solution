using Microsoft.EntityFrameworkCore;

namespace Pokedex.Models
{
  public class PokedexContext(DbContextOptions<PokedexContext> options) : base(options)
  {

  }
}