using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class TerminalStateService : ITerminalStateService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ITerminalStateRepository terminalStateRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public TerminalStateService(ITerminalStateRepository terminalStateRepository)
        {
            this.terminalStateRepository = terminalStateRepository;
        }

        public async Task<bool> DeleteTerminalState(int ID)
        {
            return await terminalStateRepository.DeleteTerminalState(ID);
        }

        public async Task<IEnumerable<TerminalState>> GetTerminalStateAsync()
        {
            return await terminalStateRepository.GetTerminalStatesAsync();
        }

        public async Task<IEnumerable<TerminalState>> GetTerminalStateAsync(string nombre)
        {
            return await terminalStateRepository.GetTerminalStatesAsync(nombre);
        }

        public async Task SaveTerminalStateAsync(TerminalState terminalState)
        {
            await terminalStateRepository.SaveTerminalStateAsync(terminalState);
        }

        public async Task UpdateTerminalState(TerminalState terminalState)
        {
            await terminalStateRepository.UpdateTerminalState(terminalState);
        }
    }
}
