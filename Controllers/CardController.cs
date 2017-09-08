using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Calling_Card.Controllers
{
    public class CardController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World!";
        }
        [HttpGet]
        [Route("{variable}")]
        public string Name(string variable)
        {
            int num;
            if(!int.TryParse(variable, out  num)){
                return $"Your name is {variable}";
            }
            else {
                return $"Yor age is {variable}";
            }
        }
        [HttpGet]
        [Route("{first}/{last}/{age}/{color}")]
        public JsonResult Card(string first, string last, int age, string color)
        {
            var Person = new {
                _FirstName = first,
                LAST_Name = last,
                Age = age,
                FavoriteColor = color
            };
            return Json(Person);
        }
        // [HttpGet]
        // [Route("")]
        // public string Index()
        // {
        //     return "Hello World!";
        // }
    }
}