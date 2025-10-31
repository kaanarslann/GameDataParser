namespace GameDataParser
{
    public class DataPrinter
    {
        public void PrintGames(List<Game> gameList)
        {
            foreach (var game in gameList)
            {
                Console.WriteLine($"{game.Title}, released in {game.ReleaseYear}, rating: {game.Rating}");
            }
        }
    }
}
