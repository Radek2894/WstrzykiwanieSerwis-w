using WstrzykiwanieSerwisów.Data;
using WstrzykiwanieSerwisów.Interfaces;
using WstrzykiwanieSerwisów.Models;

namespace WstrzykiwanieSerwisów.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PeopleContext _context;
        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetAllActivePeople()
        {
            return _context.Person.Where(p => p.IsActive);
        }
    }

}
