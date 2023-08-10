namespace LoggerApp.Loggers
{
    public class DBLogger : ILogger
    {
        public string log(string message)
        {
            return "In DB Logger: " + message + " Inserted Successfully";
        }
    }
}
