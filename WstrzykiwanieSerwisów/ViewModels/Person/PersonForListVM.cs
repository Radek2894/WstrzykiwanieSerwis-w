using WstrzykiwanieSerwisów.ViewModels.Person;

namespace WstrzykiwanieSerwisów.ViewModels.Person
{
    public class PersonForListVm
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
    }

    public class ListPersonForListVM
    {
        public List<PersonForListVm> People { get; set; }
        public int Count { get; set; }
    }
}
