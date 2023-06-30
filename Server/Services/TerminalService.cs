using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class TerminalService : ITerminalService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ITerminalRepository terminalRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public TerminalService(ITerminalRepository terminalRepository)
        {
            this.terminalRepository = terminalRepository;
        }

        public async Task<bool> DeleteTerminal(int ID)
        {
            return await terminalRepository.DeleteTerminal(ID);
        }

        public async Task<IEnumerable<Terminal>> GetTerminalsAsync()
        {
            return await terminalRepository.GetTerminalsAsync();
        }

        public async Task<IEnumerable<Terminal>> GetTerminalsAsync(string nombre)
        {
            return await terminalRepository.GetTerminalsAsync(nombre);
        }
        public async Task<IEnumerable<Terminal>> GetTerminals2Async(TerminalSearcherForm terminalForm)
        {
            return await terminalRepository.GetTerminalsAsyncBuscador(terminalForm);
        }

        public async Task SaveTerminalAsync(Terminal terminal)
        {
            await terminalRepository.SaveTerminalAsync(terminal);
        }

        public async Task UpdateTerminal(Terminal terminal)
        {
            await terminalRepository.UpdateTerminal(terminal);
        }
    }
}
