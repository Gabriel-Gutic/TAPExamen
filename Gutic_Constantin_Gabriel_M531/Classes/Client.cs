namespace Gutic_Constantin_Gabriel_M531.Classes
{
    public class Client
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public Address Address { get; set; }
        public string CreditType { get; set; }

        public Client()
        {
            Id = Guid.NewGuid();
        }
    }
}
