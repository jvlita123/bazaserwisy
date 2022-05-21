using DostepDobazySerwisy2.Data;
using DostepDobazySerwisy2.Interfaces;
using DostepDobazySerwisy2.Models;
using DostepDobazySerwisy2.ViewModels.Person;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DostepDobazySerwisy2.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PeopleContext _context;
        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetAllActivePeople()
        {
            return _context.Person.Where(p => p.IsActive);
        }
        public IQueryable<Person> GetAllPeopleFromToday()
        {
            return _context.Person.Where(p => (p.data == DateTime.Today));
        }
        public IQueryable<Person> GetAllPeople()
        {
            return _context.Person;
        }
        public void AddPerson(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();

        }
    }

}