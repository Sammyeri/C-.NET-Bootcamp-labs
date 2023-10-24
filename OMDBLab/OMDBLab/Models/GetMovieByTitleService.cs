using OMDBLab.Models.Interfaces;

namespace OMDBLab.Models
{
    public class GetMovieByIdService : IGetMovieByIdService
    {
        public async Task<Movie> GetMovieByIdAsync(string Title)
        {
            string apiUrl = $"http://www.omdbapi.com/?apikey=b7cbdcc6&t={Title}" ;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.1 Safari/537.36");
                try
                {

                    Movie movie = await client.GetFromJsonAsync<Movie>(apiUrl);

                    return movie;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return null;
        }
    }
}
