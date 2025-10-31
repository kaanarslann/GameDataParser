using System.Text.Json;

namespace GameDataParser
{
    public class DataReader
    {
        private DataPrinter printer = new DataPrinter();
        
        public void Start()
        {
            InputReader();
            Close();
        }

        private void Close()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }

        private void InputReader()
        {
            bool isInputValid = false;

            do
            {
                Console.WriteLine("Enter the name of the file you want to read:");
                string userInput = Console.ReadLine();

                if(userInput is null)
                {
                    Console.WriteLine("File name cannot be null.");
                }
                else if(userInput == "")
                {
                    Console.WriteLine("File name cannot be empty.");
                }
                else if(!File.Exists(userInput))
                {
                    Console.WriteLine("File not found.");
                }
                else if(File.Exists(userInput))
                {
                    JsonDeserializer(userInput);
                    isInputValid = true;
                }
            }
            while (!isInputValid);
        }

        private void JsonDeserializer(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            var jsonGames = JsonSerializer.Deserialize<List<Game>>(jsonString);

            printer.PrintGames(jsonGames);
        }
    }
}
