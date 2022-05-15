using WstrzykiwanieSerwisów.Models;
using WstrzykiwanieSerwisów.ViewModels.Person;

namespace WstrzykiwanieSerwisów.Interfaces
{
    public interface IPersonService
    {
        ListPersonForListVM GetPeopleForList();
        IQueryable<Person> GetActivePeople();
    }


}
