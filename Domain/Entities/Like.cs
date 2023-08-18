
namespace Domain.Entities
{
    public class Like
    {
        //The user that liked the post
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}
