using DostepDobazySerwisy2.Models;
using System.Linq;

namespace DostepDobazySerwisy2.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllActivePeople();
        IQueryable<Person> GetAllPeople();
        IQueryable<Person> GetAllPeopleFromToday();

        public void AddPerson(Person person);
    }

}