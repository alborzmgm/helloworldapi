using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {

        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public string Get()
        {
            _logger.LogInformation("Request for a hello!");
            return "Hello World!";
        }
    }
}