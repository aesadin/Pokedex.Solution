using System.Collections.Generic;

namespace Pokedex.Models
{
  public class PokeType
  {
    public PokeType()
    {
      this.Pokemon = new HashSet<Pokemon>();
    }
    public int PokeTypeId { get; set; }
    public string PokeTypeName { get; set; }
    public ICollection<Pokemon> Pokemon { get; set; }
  }
}