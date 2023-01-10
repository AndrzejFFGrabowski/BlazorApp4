using BlazorApp4.Shared;

namespace BlazorApp4.Client.Interfaces
{
    public interface IPersonService
    {
        List<Person> persons { get; set; }
        Task GetPerson();
    }
}
