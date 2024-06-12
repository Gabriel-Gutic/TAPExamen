using Gutic_Constantin_Gabriel_M531.Classes;

namespace Gutic_Constantin_Gabriel_M531.Contracts
{
    public interface IClientFactory
    {
        public Client CreateClient(string creditType);
    }
}
