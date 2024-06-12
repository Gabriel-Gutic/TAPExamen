using Gutic_Constantin_Gabriel_M531.Classes;
using Gutic_Constantin_Gabriel_M531.Contracts;

namespace Gutic_Constantin_Gabriel_M531.Services
{
    public class GeneralService : IGeneralService
    {
        public GeneralService() 
        { 
        
        }

        public void MoveClient(Guid oldBankId, Guid newBankId, Guid clientId)
        {
            var oldBank = Stocarare.GetBank(oldBankId);
            var client = oldBank.Clients.Find(c  => c.Id == clientId);
            if (client == null)
            {
                throw new Exception("Invalid client!");
            }

            var newBank = Stocarare.GetBank(newBankId);
            if (newBank.Clients.Find(c => c.Id == clientId) != null)
            {
                throw new Exception("Client already exist in this bank!");
            }
            
            newBank.Clients.Add(client);
            oldBank.Clients.Remove(client);
        }

        public bool SameClient(Guid clientId)
        {
            int count = 0;
            foreach (Bank bank in Stocarare.Banks)
            {
                if (bank.Clients.Find(c => c.Id == clientId) != null) 
                { 
                    count++;
                    if (count >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
