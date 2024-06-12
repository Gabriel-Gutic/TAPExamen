using Gutic_Constantin_Gabriel_M531.Classes;

namespace Gutic_Constantin_Gabriel_M531.Contracts
{
    public interface IBankService
    {
        public void AddClient(Guid bankId, Client client);
        public void RemoveClient(Guid bankId, Guid clientId);
        public void UpdatedData(Guid bankId, string name, Address address);
        public IEnumerable<Client> DisplayClients(Guid bankId);
        public IEnumerable<Client> FilterClients(Guid bankId, string? name, Guid? addressId, string? creditType);
    }
}
