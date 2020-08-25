using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PokedexClient.Models
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