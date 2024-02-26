using Bogus;
using EFCoreCodeFirstBogusSeedingDemo.Entities;

namespace EFCoreCodeFirstBogusSeedingDemo.Helpers
{
    public class Fakers
    {
        Faker<Address>? _addressFaker = null;
        Faker<Entities.Person>? _personFaker = null;

        public Faker<Address> GetAddressGenerator()
        {
            if (_addressFaker == null)
            {
                _addressFaker = new Faker<Address>()
                    .UseSeed(2024)
                    .RuleFor(a => a.Id, f => f.Random.Guid())
                    .RuleFor(a => a.Country, f => f.Address.Country())
                    .RuleFor(a => a.Province, f => f.Address.State())
                    .RuleFor(a => a.PostalCode, f => f.Address.ZipCode().OrNull(f, .10f))
                    .RuleFor(a => a.Suburb, f => f.Address.City().OrNull(f, .10f))
                    .RuleFor(a => a.Street, f => f.Address.StreetName().OrNull(f, .10f))
                    .RuleFor(a => a.HouseNumber, f => f.Address.BuildingNumber().OrNull(f, .10f));
            }

            return _addressFaker;
        }

        public Faker<Entities.Person> GetPersonGenerator()
        {
            if (_personFaker == null)
            {
                _personFaker = new Faker<Entities.Person>()
                .UseSeed(2024) // Set seed for deterministic data generation
                .RuleFor(a => a.Id, f => f.Random.Guid())
                .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                .RuleFor(p => p.LastName, f => f.Person.LastName)
                .RuleFor(p => p.Email, f => f.Person.Email)
                .RuleFor(p => p.ContactNumber, f => f.Phone.PhoneNumber(format: "0#########"));
            }

            return _personFaker;
        }
    }
}
