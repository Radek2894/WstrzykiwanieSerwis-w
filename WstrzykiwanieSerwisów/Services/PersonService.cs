using Extensions;
using Models.EntityModels;
using Models.ViewModels;
using WstrzykiwanieSerwisów.Interfaces;
using WstrzykiwanieSerwisów.ViewModels.Person;

namespace Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _repo;

    public PersonService(IPersonRepository repository)
    {
        _repo = repository;
    }

   

    public void AddEntry(Person person)
    {
        _repo.AddEntry(person);
    }
    public PersonListModelView GetPeople()
    {
        var people = _repo.GetAllEntries().ToModel();
        PersonListModelView result = new();

        result.People = people.ToList();
        result.Count = people.Count();
        return result;
    }

    public PersonListModelView GetPeopleToday()
    {
        var people = _repo.GetEntriesFromToday().ToModel();
        PersonListModelView result = new();

        result.People = people.ToList();
        result.Count = people.Count();
        return result;
    }
}