using BlazorApp4.Shared;

namespace BlazorApp4.Client.Interfaces
{
    public interface IPersonService
    {
        List<Person> persons { get; set; }
        Person person { get; set; }
        Task GetPerson();
        Task AddPerson(Person person);
        Task EditPerson(Person person);
        Task GetSinglePerson(int id);
        Task DeletePerson(int id);
    }
}
