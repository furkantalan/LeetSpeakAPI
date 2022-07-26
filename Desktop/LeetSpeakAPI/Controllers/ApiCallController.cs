using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class ApiCallController : ControllerBase
{
    public IActionResult Index()
    {

        HttpClient client = new HttpClient();

        HttpResponseMessage response = client.GetAsync("https://funtranslations.com/api/#leetspeak").Result;

        Response response1 = new Response();

        if (response.StatusCode == HttpStatusCode.OK)
        {
            string content = response.Content.ReadAsStringAsync().Result;
            JsonSerializerOptions options = new JsonSerializerOptions()

            {
                PropertyNameCaseInsensitive = true
            };

            response1 = JsonSerializer.Deserialize<Response>(content);
        }
        return ((IActionResult)response);

    }
}