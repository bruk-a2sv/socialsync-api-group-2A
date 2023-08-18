namespace Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int LikeCount { get; set; } 
        public int CommentCount { get; set; }
        public virtual ICollection<Tag>? Tags { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        

    }
}