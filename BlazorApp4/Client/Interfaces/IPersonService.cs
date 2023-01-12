using BlazorApp4.Shared;

namespace BlazorApp4.Client.Interfaces
{
    public interface IPersonService
    {
        List<Person> persons { get; set; }
        Task GetPerson();
        Task AddPerson(Person person);
        Task EditPerson(Person person);
        Task DeletePerson(int id);
    }
}
