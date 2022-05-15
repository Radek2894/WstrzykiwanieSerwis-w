using WstrzykiwanieSerwisów.Data;
using WstrzykiwanieSerwisów.Interfaces;
using WstrzykiwanieSerwisów.Models;
using WstrzykiwanieSerwisów.ViewModels.Person;

namespace WstrzykiwanieSerwisów.Services
{
    public class PersonService : IPersonService
    {
        private readonly PeopleContext _context;

        private readonly IPersonRepository _personRepo;

        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }


        public PersonService(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetActivePeople()
        {
            return _context.Person.Where(p => p.IsActive);
        }

        public ListPersonForListVM GetPeopleForList()
        {
            var people = _personRepo.GetAllActivePeople();
            ListPersonForListVM result = new
            ListPersonForListVM();
            result.People = new List<PersonForListVm>();
            foreach (var person in people)
            {
                // mapowanie obiektow
                var pVM = new PersonForListVm()
                {
                    Id = person.Id,
                    FullName = person.FirstName + " " +
                person.LastName
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;
        }

    }
}
