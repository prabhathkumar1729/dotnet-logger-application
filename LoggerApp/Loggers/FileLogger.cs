namespace LoggerApp.Loggers
{
    public class FileLogger : ILogger
    {
        public string log(string message)
        {
            return "In File Logger: " + message + " Inserted Successfully";
        }
    }
}
