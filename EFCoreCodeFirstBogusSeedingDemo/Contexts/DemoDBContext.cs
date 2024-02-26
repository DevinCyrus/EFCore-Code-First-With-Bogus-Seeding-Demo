using EFCoreCodeFirstBogusSeedingDemo.Entities;
using EFCoreCodeFirstBogusSeedingDemo.Helpers;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCodeFirstBogusSeedingDemo.Contexts
{
    public class DemoDBContext : DbContext
    {
        private readonly Fakers _fakers;

        public DemoDBContext(DbContextOptions<DemoDBContext> options, Fakers fakers)
        : base(options)
        {
            _fakers = fakers;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var addressess = _fakers.GetAddressGenerator().Generate(10);
            var persons = _fakers.GetPersonGenerator().Generate(10);

            //Loop through all addressess and assign a person id
            //Assumes 1-1 relationshisp and that there will be an equal number of addresses as there are persons
            for (var x = 0; x < addressess.Count; x++)
            {
                addressess[x].PersonId = persons[x].Id;
            }

            modelBuilder.Entity<Address>(
                ea =>
                {
                    //Tell EFCore to seed the table with the generated data
                    ea.HasData(addressess);
                });

            modelBuilder.Entity<Person>(
                ep =>
                {
                    //Tell EFCore to seed the table with the generated data
                    ep.HasData(persons);
                });

        }

        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Address> Addressess => Set<Address>();
    }
}
