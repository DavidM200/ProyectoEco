using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class LinesTerminalService : ILinesTerminalService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ILinesTerminalRepository linesTerminalRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LinesTerminalService(ILinesTerminalRepository linesTerminalRepository)
        {
            this.linesTerminalRepository = linesTerminalRepository;
        }
        public async Task<bool> DeleteLinesTerminal(int ID)
        {
            return await linesTerminalRepository.DeleteLinesTerminalAsync(ID);
        }

        public async Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync()
        {
            return await linesTerminalRepository.GetLinesTerminalAsync();
        }

        public async Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync(string consulta)
        {
            return await linesTerminalRepository.GetLinesTerminalAsync(consulta);
        }

        public async Task SaveLinesTerminal(LinesTerminal linesTerminal)
        {
            await linesTerminalRepository.SaveLinesTerminalAsync(linesTerminal);
        }

        public async Task UpdateLinesTerminal(LinesTerminal linesTerminal)
        {
            await linesTerminalRepository.UpdateLinesTerminal(linesTerminal);
        }
    }
}
