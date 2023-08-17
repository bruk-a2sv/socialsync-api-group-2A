

namespace SocialSync.Domain.Entities
{
    public class Post
    {
        public int ID { get; set; }
        public string PosterId { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LikesCount { get; set; }
        public string CommentCount { get; set; }
        public string Tags { get; set; }

    }
}
