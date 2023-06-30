using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ITerminalStateRepository
    {
        Task<IEnumerable<TerminalState>> GetTerminalStatesAsync();
        Task<IEnumerable<TerminalState>> GetTerminalStatesAsync(string nombre);

        Task SaveTerminalStateAsync(TerminalState terminalState);
        Task UpdateTerminalState(TerminalState terminalState);
        Task<bool> DeleteTerminalState(int ID);
    }
}
