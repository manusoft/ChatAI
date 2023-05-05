using ChatAI.Models;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace ChatAI.Services;

public class ChatService : IChatService
{
    HttpClient client;
    public ChatService()
    {
        client = new HttpClient();
        client.DefaultRequestHeaders.Add("authorization", "Bearer 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");
    }

    public async Task<string> Get(string text)
    {
        try
        {
            var content = new StringContent("{\"model\": \"text-davinci-003\", \"prompt\": \"" + text + "\",\"temperature\": 1,\"max_tokens\":100}",
        Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/completions", content);

            string responseString = await response.Content.ReadAsStringAsync();

            Root root = JsonConvert.DeserializeObject<Root>(responseString);

            return root.Choices[0].Text;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}
