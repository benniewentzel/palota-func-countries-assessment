using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Palota.Assessment.Countries.Models;

namespace Palota.Assessment.Countries.Functions
{
    public static class Ping
    {
        [FunctionName("Ping")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# Palota HTTP trigger function processed a request.");

            return new OkObjectResult(new PongResponse
            {
                Message = "Pong from Palota",
                Time = DateTimeOffset.UtcNow
            });
        }
    }
}
