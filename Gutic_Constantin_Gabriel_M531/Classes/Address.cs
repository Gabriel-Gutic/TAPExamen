namespace Gutic_Constantin_Gabriel_M531.Classes
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Apartment { get; set; }

        public Address() 
        { 
            Id = Guid.NewGuid();
        }
    }
}
