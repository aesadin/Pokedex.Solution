using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PokedexClient.Models
{
  public class Pokemon
  {
    public int PokemonId { get; set; }
    public int PokeTypeId { get; set; }
    public string Species { get; set; }
    public string Description { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string ImageMain { get; set; }
    public string ImageSprite { get; set; }
    public string ImageSilhouette { get; set; }
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpAtk { get; set; }
    public int SpDef { get; set; }
    public int Speed { get; set; }
    public string Ability { get; set; }

    public static List<Pokemon> GetPokemons()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallerTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Pokemon> pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(jsonResponse.ToString());

      return pokemonList;
    }

    public static Pokemon GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
    }
  }
}