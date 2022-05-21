using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DostepDobazySerwisy2.Data;
using DostepDobazySerwisy2.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DostepDobazySerwisy2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public virtual ICollection<Address>? Addresses
        {
            get; set;
        }
        public bool IsActive { get; set; }

        public DateTime data { get; set; }
        public ICollection<PersonGroup>? PersonGroups { get; set; }


        [Display(Name = "Twój rok urodzenia")]
        [Required(ErrorMessage = "uzupe³nij dane"), Range(1899, 2022, ErrorMessage = "Oczekiwana wartoœæ {0} z zakresu {1} i {2}.")]
        [Column(TypeName = "varchar(100)")]
        public int? Year { get; set; }

        [Display(Name = "Twoje imie")]
        [Required(ErrorMessage = "Pole jest obowi¹zkowe")]
        [MaxLength(100)]

        [Column(TypeName = "varchar(100)")]

        public string? Name { get; set; }

        [MaxLength(100)]
        [Display(Name = "Twoje nazwisko (opcjonalne)")]
        [Column(TypeName = "varchar(100)")]

        public string? Surname { get; set; }

        public string? ErrorMessage { get; set; }

        public string IsLeap(object? number)
        {

            if ((int)number % 100 != 0 && (int)number % 4 == 0 || (int)number % 400 == 0 && number != null)
            {
                this.ErrorMessage = "rok przestêpny";
                return "rok przestêpny";
            }
            this.ErrorMessage = "rok przestêpny";
            return "rok nie przestêpny";
        }

        public bool IsValid(object? value)
        {
            string array1 = Convert.ToString(value);

            if (array1[^1] != 'a')
            {
                this.ErrorMessage = "urodzi³ siê w ";
                return true;
            }

            this.ErrorMessage = "urodzi³a siê w ";
            return true;
        }



    

}
}
