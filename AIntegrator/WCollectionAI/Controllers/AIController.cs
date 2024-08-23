using Microsoft.AspNetCore.Mvc;
using System.Collections;
using WCollectionAI.Response;

/*
namespace WCollectionAI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AIController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AIController> _logger;

        public AIController(ILogger<AIController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
*/
namespace WCollectionAI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AIController : ControllerBase
    {
        private readonly ILogger<AIController> _logger;

        public AIController(ILogger<AIController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAIResponse")]
        public AIResponse Get()
        {
            return new AIResponse
            {
                Id = "chatcmpl-123",
                Object = "chat.completion",
                Created = 123456789,
                Model = "gpt-4o-mini",
                SystemFingerPrint = "fp_44709d6fcb",
                Choices = new ChoicesResponse
                {
                    Index = 0,
                    Message = new MessageResponse
                    {
                        Role = "assistant",
                        Content = "\n\nHello there, how may I assist you today?"
                    },
                    Logprobs = null,
                    FinishReason = "stop"
                },
                Usage = new UsageResponse
                {
                    PromptTokens = 1,
                    CompletionTokens = 2,
                    TotalTokens = 3
                }
            }; 
        }
    }
}
