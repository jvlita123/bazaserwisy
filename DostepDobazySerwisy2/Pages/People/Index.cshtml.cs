using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DostepDobazySerwisy2.Data;
using DostepDobazySerwisy2.Models;

namespace DostepDobazySerwisy2.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly DostepDobazySerwisy2.Data.PeopleContext _context;

        public IndexModel(DostepDobazySerwisy2.Data.PeopleContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
