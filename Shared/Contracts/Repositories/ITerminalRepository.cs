using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ITerminalRepository
    {
        Task<IEnumerable<Terminal>> GetTerminalsAsync();
        Task<IEnumerable<Terminal>> GetTerminalsAsync(string observacion);
        Task<IEnumerable<Terminal>> GetTerminalsAsyncBuscador(TerminalSearcherForm terminalForm);

        Task SaveTerminalAsync(Terminal terminal);
        Task UpdateTerminal(Terminal terminal);
        Task<bool> DeleteTerminal(int ID);

    }
}
