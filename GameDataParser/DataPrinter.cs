namespace GameDataParser
{
    public class DataPrinter
    {
        public void PrintGames(List<Game> gameList)
        {
            if(gameList.Count == 0)
            {
                Console.WriteLine("No games are present in the input file.");
            }
            foreach (var game in gameList)
            {
                Console.WriteLine($"{game.Title}, released in {game.ReleaseYear}, rating: {game.Rating}");
            }
        }
    }
}
