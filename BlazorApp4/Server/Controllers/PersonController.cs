using BlazorApp4.Server.Tools;
using BlazorApp4.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public static List<Person> persons = new List<Person>();
        /*
        {
            new Person { Id = 1,name="na"}
            ,new Person { Id = 2,name="me"}
        };
        */

        public PersonController()
        {
        }


        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPerson()
        {
            //var res = await Http.GetJsonAsync<List<Person>>("/data");

            //(HttpMethod.Post, "/api/Customer",< List<Person>>("data.json");
            persons = await Database.ReadTextAsync();
            
            return Ok(persons);
        }
        [HttpPost]
        public async Task<ActionResult> AddPerson(Person person)
        {
            //var result = await _http.GetFromJsonAsync<List<Person>>("C:\\data.json");
            persons = await Database.ReadTextAsync();
            Person x = persons.Find(p => p.Id == person.Id);
            if (x != null)
            {
                return StatusCode(409);
            }
            persons.Add(person);
            await Database.WriteTextAsync(persons);
            Console.WriteLine("tada");
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> EditPerson(Person person)
        {
            //var result = await _http.GetFromJsonAsync<List<Person>>("C:\\data.json");
            persons = await Database.ReadTextAsync();
            Person x = persons.Find(p => p.Id == person.Id);
            if (x == null)
            {
                return StatusCode(404);
            }
            persons.Remove(x);
            persons.Add(person);
            await Database.WriteTextAsync(persons);
            Console.WriteLine("tada");
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePerson(int id)
        {
            persons = await Database.ReadTextAsync();
            Person x = persons.Find(p => p.Id == id);
            if (x == null)
            {
                return NotFound();
            }
            persons.Remove(x);
            await Database.WriteTextAsync(persons);
            return Ok();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Person>>> GetPerson(int id)
        {
            var someone = persons.FirstOrDefault(h => h.Id == id);
            if (someone == null)
            {
                return NotFound("No person:/");
            }
            return Ok(persons);
        }
    }
}
