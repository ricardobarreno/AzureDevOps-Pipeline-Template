using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace azure_function_dotnet
{
    public class Dummy
    {
        private readonly ILogger<Dummy> _logger;

        public Dummy(ILogger<Dummy> logger)
        {
            _logger = logger;
        }

        [Function("Dummy")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult(new { message = "Hello World!" });
        }
    }
}
