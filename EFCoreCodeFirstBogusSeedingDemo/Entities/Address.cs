namespace EFCoreCodeFirstBogusSeedingDemo.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; } //Foreign Key to Person
        public Person? Person { get; set; } //Navigation property for the person associated with the address
        public string Country { get; set; } = "";
        public string Province { get; set; } = "";
        public string? PostalCode { get; set; } = "";
        public string? Suburb { get; set; } = "";
        public string? Street { get; set; } = "";
        public string? HouseNumber { get; set; } = "";
        public bool IsDeleted { get; set; } = false;
    }
}
