using DeckOfCardsLab.Models.Interfaces;

namespace DeckOfCardsLab.Models
{
    public class DeckOfCardService : IDeckOfCardsService
    {
        public async Task<string> CreateNewDeckAsync()
        {
            string apiUrl = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    GenerateDeckResponse generateDeckResponse = await client.GetFromJsonAsync<GenerateDeckResponse>(apiUrl);

                    if(generateDeckResponse == null)
                    {
                        return null;
                    }

                    return generateDeckResponse.deck_id;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }

        public async Task<List<Card>> GetCardsAsync(string deckid)
        {
            string apiUrl = $"https://deckofcardsapi.com/api/deck/{deckid}/draw/?count=5";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    DrawDeckResponse drawDeckResponse = await client.GetFromJsonAsync<DrawDeckResponse>(apiUrl);

                    return drawDeckResponse.cards;
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
