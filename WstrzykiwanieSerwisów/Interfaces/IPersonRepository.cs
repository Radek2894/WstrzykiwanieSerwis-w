using WstrzykiwanieSerwisów.Models;

namespace WstrzykiwanieSerwisów.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllActivePeople();
    }

}
