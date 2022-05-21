using DostepDobazySerwisy2.Interfaces;
using DostepDobazySerwisy2.Models;
using DostepDobazySerwisy2.ViewModels.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace DostepDobazySerwisy2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;


      //  public ListPersonForListVM Records { get; set; }
      //  public ListPersonForListVM AllRecords { get; set; }
        public ListPersonForListVM AllRecordsFromToday { get; set; }

        [BindProperty]
        public Person Person { get; set; }

        public List<Person> members = new();
        [BindProperty]

        public List<Person> People { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;

        }

        public void OnGet()
        {
           // Records = _personService.GetPeopleForList();
           // AllRecords = _personService.GetAllEntries();
            AllRecordsFromToday = _personService.GetEntriesFromToday();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Person.data = DateTime.Today;
                Person.IsActive = true;
                _personService.AddEntry(Person);//Dodanie wpisu do bazy danych
            }

            return RedirectToPage("/Index");
        }
    }
}
