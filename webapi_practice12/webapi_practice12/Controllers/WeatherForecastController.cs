using Microsoft.AspNetCore.Mvc;
//using webapi_practice12.Models;

namespace webapi_practice12.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        static List<string> l1=new List<string>()
        {
            "val0","val1"
        };

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }   

        [HttpGet]
        
        public IEnumerable<string> Get(int id)
        {
            return l1;
        }
        [HttpPost]
        public IActionResult Post([FromBody]string val)
        {
            l1.Add(val);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put([FromBody]int id,string val)
        {
            l1[id] = val;
            return Ok();
        }
        [HttpDelete]
        public string Delete(int id)
        {
            l1.RemoveAt(id);
            return "deleted";
        }
    }
}