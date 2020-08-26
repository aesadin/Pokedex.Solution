using System.Threading.Tasks;
using RestSharp;

namespace PokedexClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllHelper()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"pokemon", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetPokemonHelper(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"pokemon/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllPokeTypesHelper()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"poketypes", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetPokeTypesHelper(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"poketypes/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    // public static async Task<string> GetAllUsers()
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"user", Method.Get);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

    // public static async Task<string> GetUsers(int id)
    // {
    //   RestClient client = new RestClient("http:localhost:5000/api");
    //   RestRequest request = new RestRequest($"user/{id}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }
    
    
    // public static async Task Post(string newPokemon)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"user", Method.POST);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newPokemon);
    //   var response = await client.ExecuteTaskAsync(request);
    // }
    
    // public static async Task Put(int id, string newPokemon)
    // {
    //   RestClient client = new RestClient($"http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"user/{id}", Method.PUT);
    //   request.AddHeader("Content-Type", "application/json");
    //   request.AddJsonBody(newPokemon);
    //   var response = await client.ExecuteTaskAsync(request);
    // }

    // public static async Task Delete(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5000/api");
    //   RestRequest request = new RestRequest($"user/{id}", Method.DELETE);
    //   request.AddHeader("Content-Type", "application/json");
    //   var response = await client.ExecuteTaskAsync(request);
    // }
  }
}