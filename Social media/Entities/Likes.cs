namespace Social_media.Entities
{
    public class Likes
    {
    public int UserId { get; set; }
    public int PostId { get; set; }
    public Users Users { get; set; }
    public Posts Posts { get; set; }
    }
}
 
