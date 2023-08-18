



using Domain.Entities;
namespace Application.Contracts.Persistance;
public interface IPostRepository : IGenericRepository<Post>
{
    Task<List<Post>> GetFollowingPost(int id);
    Task<List<Post>> GetUserPost(int id);
    Task<List<Post>> SearchByHashtag(string tags);
    Task<List<Post>> SearchByContent(string tags);
}