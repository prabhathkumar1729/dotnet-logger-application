using LoggerApp.Loggers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ILogger = LoggerApp.Loggers.ILogger;

namespace LoggerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggerAppController : ControllerBase
    {
     
        private readonly ILogger _logger;
        public LoggerAppController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpPut]
        public string Put(string value)
        {
            return _logger.log(value);
        }
    }
}
