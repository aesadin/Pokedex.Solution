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
    public int UserId { get; set; }
    public string Name { get; set; }
    public ICollection<Pokemon> Pokemon { get; set; }
  }
}