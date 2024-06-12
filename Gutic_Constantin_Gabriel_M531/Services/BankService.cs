using Gutic_Constantin_Gabriel_M531.Classes;
using Gutic_Constantin_Gabriel_M531.Contracts;

namespace Gutic_Constantin_Gabriel_M531.Services
{
    public class BankService : IBankService
    {
        public void AddClient(Guid bankId, Client client)
        {
           var bank = Stocarare.GetBank(bankId);

            bank.Clients.Add(client);
        }

        public void RemoveClient(Guid bankId, Guid clientId)
        {
            var bank = Stocarare.GetBank(bankId);

            var client = bank.Clients.Find(c => c.Id == clientId);
            if (client == null)
            {
                throw new Exception("Invalid client id!");
            }

            bank.Clients.Remove(client);
        }

        public void UpdatedData(Guid bankId, string name, Address address)
        {
            var bank = Stocarare.GetBank(bankId);
            
            bank.Name = name;
            bank.Address = address;
        }

        public IEnumerable<Client> DisplayClients(Guid bankId)
        {
            var bank = Stocarare.GetBank(bankId);
            return bank.Clients;
        }

        public IEnumerable<Client> FilterClients(Guid bankId, string? name, Guid? addressId, string? creditType)
        {
            var clients = Stocarare.GetBank(bankId).Clients;

            if (name != null)
            {
                clients = clients.FindAll(c => c.FirstName == name || c.LastName == name);
            }

            if (addressId != null)
            {
                clients = clients.FindAll(c => c.Address.Id == addressId);
            }

            if (creditType != null)
            {
                clients = clients.FindAll(c => c.CreditType == creditType);
            }

            return clients;
        }
    }
}
