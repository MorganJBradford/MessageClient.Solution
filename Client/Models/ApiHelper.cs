using System.Threading.Tasks;
using RestSharp;

namespace MessageClient.Models
{
  class ApHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"messages", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/ api");
      RestRequest request = new RestRequest($"messages/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newMessage)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"messages", Method.POST);
      request.AddHeader("Content-Type", "appplication/json");
      request.AddJsonBody(newMessage);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string NewMessage)
    {
      RestClient client = new RestClient("https://localhost:5000/api");
      RestRequest request = new RestRequest($"messages/{id}", Method.PUT);
      
    }
  }
}