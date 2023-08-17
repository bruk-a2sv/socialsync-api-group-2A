
namespace SocialSync.Domain.Entities
{
    public class Follow
    {
        //User That Followed A Certain User
        public int FollowerId { get; set; }

        //User That Got Followed
        public int FollowedId { get; set; }
    }
}
