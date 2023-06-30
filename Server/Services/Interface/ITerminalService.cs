using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface ITerminalService
    {
        Task<IEnumerable<Terminal>> GetTerminalsAsync();

        Task<IEnumerable<Terminal>> GetTerminalsAsync(string observacion);
        Task<IEnumerable<Terminal>> GetTerminals2Async(TerminalSearcherForm terminalForm);

        Task SaveTerminalAsync(Terminal terminal);
        Task UpdateTerminal(Terminal terminal);
        Task<bool> DeleteTerminal(int ID);

    }
}
