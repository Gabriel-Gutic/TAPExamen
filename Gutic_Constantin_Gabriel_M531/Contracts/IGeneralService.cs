using Gutic_Constantin_Gabriel_M531.Classes;

namespace Gutic_Constantin_Gabriel_M531.Contracts
{
    public interface IGeneralService
    {
        public void MoveClient(Guid oldBankId, Guid newBankId, Guid clientId);
        public bool SameClient(Guid clientId);
    }
}
