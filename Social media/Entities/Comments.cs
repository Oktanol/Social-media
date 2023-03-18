namespace Social_media.Entities
{
    public class Comments
    {
    public int Id { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public Users Users { get; set; }
    public Posts Posts { get; set; }

    }
}
