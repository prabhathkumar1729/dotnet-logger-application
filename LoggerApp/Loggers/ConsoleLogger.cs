namespace LoggerApp.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public string log(string message)
        {
            return "In Console Logger: " + message + " Inserted Successfully";
        }
    }
}
