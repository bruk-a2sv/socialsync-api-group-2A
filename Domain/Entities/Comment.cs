
namespace Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; } 
        public required string Content { get; set; }

        //The User That Commented
        public int UserId { get; set; }
        public int PostId { get; set; }

    }
}
