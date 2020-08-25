using RestSharp;
using System.Threading.Tasks;

namespace PokedexClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"pokemon", Method.Get);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http:localhost:5000/api");
      RestRequest request = new RestRequest($"pokemon/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"poketype", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http:localhost:5000/api");
      RestRequest request = new RestRequest($"poketype/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"user", Method.Get);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http:localhost:5000/api");
      RestRequest request = new RestRequest($"user/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    
    
    public static async Task Post(string newPokemon)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"pokemon", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newPokemon);
      var response = await client.ExecuteTaskAsync(request);
    }
    
    public static async Task Put(int id, string newPokemon)
    {
      RestClient client = new RestClient($"http://localhost:5000/api");
      RestRequest request = new RestRequest($"pokemon/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newPokemon);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"pokemon/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}