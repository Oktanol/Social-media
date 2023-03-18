namespace Social_media.Entities
{
    public class Posts
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public string text { get; set; }
        public DateTime Date { get; set; }

    }
}
