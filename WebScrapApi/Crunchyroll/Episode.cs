namespace WebScrapApi.Crunchyroll
{
    public class Episode
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Story { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
    }
}
