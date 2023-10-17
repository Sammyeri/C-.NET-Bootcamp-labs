namespace PaupersRedditLab.Models.Interfaces
{
    public interface IGetPostsService
    {
        Task<Response> GetPosts();
    }
}
