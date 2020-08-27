using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Models
{
  public class User
  {
    public User()
    {
      this.Pokemon = new HashSet<UserPokemon>();
    }
    public int UserId { get; set; }
    public string Name { get; set; }
    public ICollection<UserPokemon> Pokemon { get; set; }
  }
}
//Build many to many relationship between user and pokemon so we can remove pokemon from that user without removing it from the database