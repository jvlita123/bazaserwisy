using DostepDobazySerwisy2.Interfaces;
using DostepDobazySerwisy2.Models;
using DostepDobazySerwisy2.ViewModels.Person;
using System.Collections.Generic;
namespace DostepDobazySerwisy2.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepo;
        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public ListPersonForListVM GetPeopleForList()
        {
            var people = _personRepo.GetAllActivePeople();
            ListPersonForListVM result = new ListPersonForListVM();
            result.People = new List<PersonForListVM>();
            foreach (var person in people)
            {
                // mapowanie obiektow
                var pVM = new PersonForListVM()
                {
                    Id = person.Id,
                    FullName = person.Name + " " +
                person.Surname
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;

        }
        public void AddEntry(Person person)
        {
            _personRepo.AddPerson(person);
        }
        public ListPersonForListVM GetAllEntries()
        {
            var people = _personRepo.GetAllPeople();
            ListPersonForListVM result = new ListPersonForListVM();
            result.People = new List<PersonForListVM>();
            foreach (var person in people)
            {
                // mapowanie obiektow
                var pVM = new PersonForListVM()
                {
                    Id = person.Id,
                    FullName = person.Name + " " +
                person.Surname
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;
        }
        public ListPersonForListVM GetEntriesFromToday()
        {
            var people = _personRepo.GetAllPeopleFromToday();
            ListPersonForListVM result = new ListPersonForListVM();
            result.People = new List<PersonForListVM>();
            foreach (var person in people)
            {
                // mapowanie obiektow
                var pVM = new PersonForListVM()
                {
                    Id = person.Id,
                    FullName = person.Name + " " +
                person.Surname
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;
        }

    }
}