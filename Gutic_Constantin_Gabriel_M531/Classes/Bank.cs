namespace Gutic_Constantin_Gabriel_M531.Classes
{
    public class Bank
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Client> Clients { get; set; }
        public decimal GeneralInterest { get; set; }

        public Bank()
        {
            Id = Guid.NewGuid();
        }
    }
}
