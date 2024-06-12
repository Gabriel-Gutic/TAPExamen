using Gutic_Constantin_Gabriel_M531.Classes;
using Gutic_Constantin_Gabriel_M531.Contracts;

namespace Gutic_Constantin_Gabriel_M531.Services
{
    public class ClientFactory : IClientFactory
    {
        private readonly Random _random;

        public ClientFactory()
        {
            _random = new Random();
        }
        
        public Client CreateClient(string creditType)
        {
            Client client = new Client()
            {
                LastName = RandomString(_random.Next(6, 10)),
                FirstName = RandomString(_random.Next(6, 10)),
                Birthdate = DateTime.Now.AddYears(_random.Next(-40, -20)),
                Address = new Address()
                {
                    Street = RandomString(_random.Next(6, 20)),
                    Number = _random.Next(6, 20),
                    Apartment = RandomString(1)
                },
                CreditType = creditType,
            };

            return client;
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
