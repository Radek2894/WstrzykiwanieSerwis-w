using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.EntityModels;
using WstrzykiwanieSerwisów.Interfaces;


namespace WstrzykiwanieSerwisów.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;
        public Person Person { get; set; }
        public bool IsValidated { get; set; } = false;

        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Person.Name.Any(x => "123456789".Contains(x)))
                {
                    ModelState.AddModelError("Person.Name", "Imiona nie mogą zawierać liczb");
                }
                else if (Person.LastName.Any(x => "123456789".Contains(x)))
                {
                    ModelState.AddModelError("Person.LastName", "Nazwiska nie mogą zawierać liczb");
                }
                else
                {
                    Person.DataRetrievedTime = DateTime.Now;
                    _personService.AddEntry(Person);
                    IsValidated = true;
                }
            }
            return Page();

        }
    }
}