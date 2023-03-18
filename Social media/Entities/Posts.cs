namespace Social_media.Entities
{
    public class Posts
    {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public Users Users { get; set; }
    public List<Comments> Comments { get; set; }
    public List<Likes> Likes { get; set; }

    }
}
