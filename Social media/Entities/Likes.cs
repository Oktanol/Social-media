namespace Social_media.Entities
{
    public class Likes
    {
        public int Id { get; set; }
        public Posts Post { get; set; }
        public Users User { get; set; }
        public DateTime Date { get; set; }
    }
}
 