using Microsoft.AspNetCore.Mvc;
using TestAPI.Model;
//added comment
namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableDetailsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
          "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TableDetailsController> _logger;

        public TableDetailsController(ILogger<TableDetailsController> logger)
        {
            _logger = logger;
        }

        /* [HttpGet(Name = "GetWeatherForecast")]
         public IEnumerable<WeatherForecast> Get()
         {
             return Enumerable.Range(1, 5).Select(index => new WeatherForecast
             {
                 Date = DateTime.Now.AddDays(index),
                 TemperatureC = Random.Shared.Next(-20, 55),
                 Summary = Summaries[Random.Shared.Next(Summaries.Length)]
             })
             .ToArray();
         }*/


       [HttpGet(Name = "GetTableDetails")]
        public ActionResult GetTableDetails(string text)
        {
            var result = new tablemodel();
            switch (text)
            {
                case "Consumer product and product lines":                   
                    result.Table_Name = "MDM_Parties_Data_Dictionary";
                    result.Attribute_Name = "HAS_OPEN_CONS_PROD";
                    result.Attribute_Desc = "Owns any open consumer product";
                    break;
                case "Consumers who have large balance in their account":
                    result.Table_Name = "Table 2";
                    result.Attribute_Name = "Def";
                    result.Attribute_Desc = "Def row";
                    break;
                case "table_3":
                    result.Table_Name = "Table 3";
                    result.Attribute_Name = "Ghi";
                    result.Attribute_Desc = "Ghi row";
                    break;
                case "table_4":
                    result.Table_Name = "Table 4";
                    result.Attribute_Name = "Jkl";
                    result.Attribute_Desc = "Jkl row";
                    break;
                default:break;
            }
            return Ok(result);
        }


    }
}
