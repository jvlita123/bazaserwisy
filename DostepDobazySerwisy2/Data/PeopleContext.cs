using DostepDobazySerwisy2.Models;
using Microsoft.EntityFrameworkCore;

namespace DostepDobazySerwisy2.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }


        public PeopleContext(DbContextOptions options) : base(options)
        {




        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //dodajemy parê kluczy do tabeli poœrednicz¹cej do relacji many to many
            builder.Entity<PersonGroup>().HasKey(pg => new { pg.PersonId, pg.GroupId });
            //w tabeli posredniczacej PersonGroup
            builder.Entity<PersonGroup>()
            .HasOne<Person>(pg => pg.Person) // dla jednej osoby
            .WithMany(p => p.PersonGroups) // jest wiele PersonGroups
            .HasForeignKey(p => p.PersonId); // a powizanie jest realizowane przez klucz obcy PersonIdw tabeli posredniczacej PersonGroup
            builder.Entity<PersonGroup>()
            .HasOne<Group>(pg => pg.Group) // dla jednej grupy
            .WithMany(g => g.PersonGroups) // jest wiele PersonGroups
            .HasForeignKey(g => g.GroupId); // a powizanie jestrealizowane przez klucz obcy GroupId
        }


    }

}