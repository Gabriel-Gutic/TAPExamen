using Gutic_Constantin_Gabriel_M531.Classes;

namespace Gutic_Constantin_Gabriel_M531.Dto
{
    public class ClientDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public string AddressStreet { get; set; }
        public int AddressNumber { get; set; }
        public string AddressApartment { get; set; }
        public string CreditType { get; set; }
    }
}
