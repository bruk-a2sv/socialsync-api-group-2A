

namespace SocialSync.Domain.Entites
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public int FollowerCount { get; set; }
        public int FollowingCount { get; set; }
        public int PostsCount { get; set; }
        public string ProfilePicture { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAccountVerified { get; set; }

    }
}
