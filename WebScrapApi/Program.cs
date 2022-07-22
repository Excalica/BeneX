using WebScrapApi.Crunchyroll;
using WebScrapApi;
namespace WebScrapApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Crunchyroll = new CrunchyrollAPI();

            List<string> AnimeURLList = Crunchyroll.GetAllAnimeURLsAsync(Browser.Firefox).Result;
            Console.WriteLine(AnimeURLList.Count);

            foreach (var url in AnimeURLList)
            {
                var animes = Crunchyroll.GetAnimeByUrlAsync(url).Result;
                Console.WriteLine(animes.ToString());
            }
            Console.ReadKey();
        }
    }
}