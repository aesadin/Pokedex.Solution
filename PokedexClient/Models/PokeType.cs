using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace PokedexClient.Models
{
  public class PokeType
  {
    public PokeType()
    {
      this.Pokemon = new HashSet<Pokemon>();
    }
    public int PokeTypeId { get; set; }
    [DisplayName("Type")]
    public string PokeTypeName { get; set; }
    public ICollection<Pokemon> Pokemon { get; set; }
 
    public static List<PokeType> GetPokeTypes()
    {
      var apiCallTask = ApiHelper.GetAllPokeTypesHelper();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<PokeType> pokeList = JsonConvert.DeserializeObject<List<PokeType>>(jsonResponse.ToString());

      return pokeList;
    }
    public static PokeType GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetPokeTypesHelper(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      PokeType pokeType = JsonConvert.DeserializeObject<PokeType>(jsonResponse.ToString());

      return pokeType;
    }
  }
}