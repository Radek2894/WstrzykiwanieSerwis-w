using Models.EntityModels;
using WstrzykiwanieSerwisów.Models;

namespace WstrzykiwanieSerwisów.Interfaces
{
    public interface IPersonRepository
    {
        public void AddEntry(Person person);

        public IQueryable<Person> GetAllEntries();

        public IQueryable<Person> GetEntriesFromToday();
    }

}
