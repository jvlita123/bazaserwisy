﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly DostepDobazySerwisy2.Data.PeopleContext _context;

        public DetailsModel(DostepDobazySerwisy2.Data.PeopleContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Person.FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
