using BlazorApp4.Client.Interfaces;
using BlazorApp4.Shared;
using System.Net.Http.Json;

namespace BlazorApp4.Client.Services
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _http;
        public PersonService(HttpClient http)
        {
            _http = http;
        }
        public List<Person> persons { get; set; } = new List<Person>();
        public Person person { get; set; } = new Person(0, "");
        private const string uri = "api/Person";
        public async Task GetPerson()
        {
            var result = await _http.GetFromJsonAsync<List<Person>>(uri);
            if (result != null)
                persons = result;
        }
        public async Task AddPerson(Person person)
        {
            var result = await _http.PostAsJsonAsync<Person>(uri, person);
        }
        public async Task EditPerson(Person person)
        {
            var result = await _http.PutAsJsonAsync<Person>(uri, person);
        }

        public async Task DeletePerson(int id)
        {
            var result = await _http.DeleteAsync(uri + "/" + id.ToString());
        }

        public async Task GetSinglePerson(int id)
        {
            Console.WriteLine("service 0");
            var result = await _http.GetFromJsonAsync<Person>("api/Person/{id}");
            Console.WriteLine("service 1");
            if (result != null)
            {
                person = result;
                Console.WriteLine("service ", result);
            }

        }
    }
}
