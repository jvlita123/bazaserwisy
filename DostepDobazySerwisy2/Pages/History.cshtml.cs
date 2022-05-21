using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DostepDobazySerwisy2.Data;
using DostepDobazySerwisy2.Models;
using DostepDobazySerwisy2.ViewModels.Person;
using DostepDobazySerwisy2.Interfaces;

namespace DostepDobazySerwisy2.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly DostepDobazySerwisy2.Data.PeopleContext _context;
        public ListPersonForListVM AllRecords { get; set; }
        private readonly IPersonService _personService;

        public HistoryModel(DostepDobazySerwisy2.Data.PeopleContext context, DostepDobazySerwisy2.Interfaces.IPersonService personService)
        {
            _context = context;
            _personService = personService;
        }


        [BindProperty]
        public Person Person { get; set; }


        public IActionResult OnGet()
        {
            AllRecords= _personService.GetAllEntries();

            return Page();
        }
    }
}
