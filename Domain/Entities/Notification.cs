
namespace SocialSync.Domain.Entities
{
    public class Notification
    {
        public int ID { get; set; }

        //The User That Should Get Notified
        public string UserId { get; set; }
        public int PostId { get; set; }
        public bool IsRead { get; set; }
        public DateTime DoneAt { get; set; }
    }

}
