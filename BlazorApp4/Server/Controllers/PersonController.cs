using BlazorApp4.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public static List<Person> persons = new List<Person>
        {
            new Person { Id = 1,name="na"}
            ,new Person { Id = 2,name="me"}
        };


        public PersonController()
        {
        }


        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPerson()
        {
            //var res = await Http.GetJsonAsync<List<Person>>("/data");

            //(HttpMethod.Post, "/api/Customer",< List<Person>>("data.json");
            //persons = await Database.ReadTextAsync();
            return Ok(persons);
        }
    }
}
