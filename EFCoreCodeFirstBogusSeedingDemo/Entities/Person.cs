namespace EFCoreCodeFirstBogusSeedingDemo.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string ContactNumber { get; set; } = "";
        public bool IsDeleted { get; set; } = false;
        public Address? Address { get; set; } //Navigation property for the associated address
    }
}
