namespace WebScrapApi.Crunchyroll
{
    public class Seasons
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public Episode[] Episodes { get; set; }
    }
}
