

using PaupersRedditLab.Models.Interfaces;

namespace PaupersRedditLab.Models
{
    public class GetPostsService : IGetPostsService
    {
        public async Task<Response> GetPosts()
        {
            string apiUrl = "https://www.reddit.com/r/aww/.json";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.1 Safari/537.36");
                try
                {
                    Response response = await client.GetFromJsonAsync<Response>(apiUrl);
                    
                    return response;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }

 
    }
}
