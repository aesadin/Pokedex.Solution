using System.Collections.Generic;

namespace Pokedex.Models
{
  public class Type
  {
    public Type()
    {
      this.Pokemon = new HashSet<Pokemon>();
    }
    public int TypeId { get; set; }
    public string TypeName { get; set; }
    public ICollection<Pokemon> Pokemon { get; set; }
  }
}