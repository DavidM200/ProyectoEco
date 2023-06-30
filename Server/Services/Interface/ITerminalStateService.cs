using GestionTelefonos.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface ITerminalStateService
    {
        Task<IEnumerable<TerminalState>> GetTerminalStateAsync();
        Task<IEnumerable<TerminalState>> GetTerminalStateAsync(string nombre);

        Task SaveTerminalStateAsync(TerminalState terminalState);
        Task UpdateTerminalState(TerminalState terminalState);
        Task<bool> DeleteTerminalState(int ID);
    }
}
