namespace DeckOfCardsLab.Models.Interfaces
{
    public interface IDeckOfCardsService
    {
        Task<string> CreateNewDeckAsync();
        Task<List<Card>> GetCardsAsync(string deckId);
    }
}
