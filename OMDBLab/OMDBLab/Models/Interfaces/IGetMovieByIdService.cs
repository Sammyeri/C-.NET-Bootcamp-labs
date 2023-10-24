namespace OMDBLab.Models.Interfaces
{
    public interface IGetMovieByIdService
    {
        Task<Movie> GetMovieByIdAsync(string id);
    }
}
