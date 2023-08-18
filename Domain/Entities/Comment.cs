
namespace SocialSync.Domain.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }

        //The User That Commented
        public int UserId { get; set; }
        public int PostId { get; set; }

    }
}
