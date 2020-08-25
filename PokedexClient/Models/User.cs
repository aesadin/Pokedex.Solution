using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PokedexClient.Models
{
  public class User : IdentityUser
  {
    public int UserId { get; set; }
    public string Name { get; set; }
    public ICollection<Pokemon> Pokemon { get; set; }

    public static User GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConver.DeserializeObject<JObject>(result);
      User user = JsonConvert.DeserializeObject<User>(jsonResponse.ToString());

      return user;
    }

    public static void Post(User user)
    {
      string jsonUser = JsonConver.SerializeObject(user);
      var apiCallTask = ApiHelper.Post(jsonUser);
    }

    public static void Put(User user)
    {
      string jsonUser = JsonConvert.SerializeObject(user);
      var apiCallTask = ApiHelper.Put(user.UserId, jsonUser);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}
