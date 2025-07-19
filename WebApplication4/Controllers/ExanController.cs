using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("api/tools")]
    public class ExanController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return new Random().Next(0, 101);
        }

        [HttpGet("greet")]
        public async Task<string> Greet(string name)
        {
            await Task.Delay(2000);
            return $"Salom, {name}";
        }

        [HttpGet("today")]

        public string Today()
        {
            return DateTime.Today.ToString("yyyy-MM-dd ");
        }


        [HttpGet("length")]
        public int Length(string text)
        {
            return text.Length;
        }

        [HttpGet("sqrt")]

        public double sqrt(double value)
        {
            return Math.Sqrt(value);
        }

    }


}

