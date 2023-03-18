namespace Social_media.Entities
{
    public class Users
    {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }

    public User User { get; set; }
    public List<Comment> Comments { get; set; }
    public List<Like> Likes { get; set; }
    }
}
