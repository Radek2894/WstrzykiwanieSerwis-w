using Models.EntityModels;
using Models.ViewModels;
using WstrzykiwanieSerwisów.Models;

namespace Extensions;

public static class ModelExtensions
{
    public static IQueryable<PersonModelView> ToModel(this IQueryable<Person> source)
    {
        return source.Select(person => new PersonModelView()
        {
            Id = person.PersonId,
            FullName = person.Name + " " + person.LastName
        });
    }
}
