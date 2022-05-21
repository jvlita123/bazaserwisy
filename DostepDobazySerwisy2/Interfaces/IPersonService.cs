using DostepDobazySerwisy2.Models;
using DostepDobazySerwisy2.ViewModels.Person;
using System.Collections.Generic;
namespace DostepDobazySerwisy2.Interfaces
{
    public interface IPersonService
    {
        ListPersonForListVM GetPeopleForList();
        public void AddEntry(Person person);
        ListPersonForListVM GetEntriesFromToday();

        public ListPersonForListVM GetAllEntries();
    }

}