using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class LinesEmployeeTerminalService : ILinesEmployeeTerminalService
    {
        ILinesEmployeeTerminalRepository linesEmployeeTerminalRepository;
        public LinesEmployeeTerminalService(ILinesEmployeeTerminalRepository linesEmployeeTerminalRepository)
        {
            this.linesEmployeeTerminalRepository = linesEmployeeTerminalRepository;
        }
        public async Task<bool> DeleteLinesEmployeeTerminal(int ID)
        {
            return await linesEmployeeTerminalRepository.DeleteLinesEmployeeTerminalAsync(ID);
        }

        public async Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeesTerminalsAsync(string consulta)
        {
            return await linesEmployeeTerminalRepository.GetLinesEmployeeTerminalsAsync(consulta);
        }

        public async Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeesTerminalsAsync()
        {
            return await linesEmployeeTerminalRepository.GetLinesEmployeeTerminalsAsync();
        }

        public async Task SaveLinesEmployeeTerminal(LinesEmployeeTerminal linesEmployeeTerminal)
        {
            await linesEmployeeTerminalRepository.SaveLinesEmployeeTerminalAsync(linesEmployeeTerminal);
        }

        public async Task UpdateLinesEmployeeTerminal(LinesEmployeeTerminal linesEmployeeTerminal)
        {
            await linesEmployeeTerminalRepository.UpdateLinesEmployeeTerminal(linesEmployeeTerminal);

        }
    }
}
