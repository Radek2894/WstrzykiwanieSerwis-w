using Models.EntityModels;
using Models.ViewModels;
using WstrzykiwanieSerwisów.Models;
using WstrzykiwanieSerwisów.ViewModels.Person;

namespace WstrzykiwanieSerwisów.Interfaces
{
    public interface IPersonService
    {
   
        public void AddEntry(Person person);

        public ListPersonForListVM GetPeople();

        public ListPersonForListVM GetPeopleToday();
      
    }


}
