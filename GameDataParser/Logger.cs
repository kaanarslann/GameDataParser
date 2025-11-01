namespace GameDataParser
{
    public abstract class Logger
    {
        public static void Log(Exception exception)
        {
            string fileName = "log.txt";

            var newException = $"[{DateTime.Now}], Exception message: {exception.Message}, Stack trace: {exception.StackTrace}";
            File.AppendAllText(fileName, newException + Environment.NewLine);
        }
    }
}
