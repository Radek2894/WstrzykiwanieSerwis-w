using Models.EntityModels;
using WstrzykiwanieSerwisów.Data;
using WstrzykiwanieSerwisów.Interfaces;

namespace Data.Repository;

public class PersonRepository : IPersonRepository
{
    private readonly PeopleContext _context;
    public PersonRepository(PeopleContext context)
    {
        _context = context;
    }
    public void AddEntry(Person person)
    {
        _context.Add(person);
        _context.SaveChanges();
    }

    public IQueryable<Person> GetAllEntries()
    {
        return from person in _context.Person select person;
    }

    public IQueryable<Person> GetEntriesFromToday()
    {
        return from person in _context.Person
               where person
               .DataRetrievedTime.Date == DateTime.Today.Date
               select person;
    }
}

