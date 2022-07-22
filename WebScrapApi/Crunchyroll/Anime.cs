namespace WebScrapApi.Crunchyroll
{
    public class Anime
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public Seasons[] Seasons { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }

        public string Rating { get; set; }
        public string[] Tags { get; set; }
        public string Publisher { get; set; }

        public override string? ToString()
        {
            int n = 0;

            foreach (var season in Seasons)
            {
                foreach (var episode in season.Episodes)
                {
                    n++;
                }
            }
            string tags = string.Empty;

            foreach (var tag in Tags)
            {
                tags += tag + ", ";
            }
            tags = tags.Remove(tags.Length - 2, 1);

            return $"ID: {ID}\n\nName: {Name}\n\nDescription: {Description}\nUrl: {Url}\n\nImage: {Image}\n\nSeasons: {Seasons.Length}\n\nEpisodes: {n}\n\nRating: {Rating}\n\nTags: {tags}\n\nPublisher: {Publisher}";
        }
    }


}
