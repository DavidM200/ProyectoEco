using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ILinesEmployeeTerminalRepository
    {
        Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeeTerminalsAsync();
        Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeeTerminalsAsync(string consulta);
        Task SaveLinesEmployeeTerminalAsync(LinesEmployeeTerminal linesEmployeeTerminal);
        Task UpdateLinesEmployeeTerminal(LinesEmployeeTerminal linesEmployeeTerminal);
        Task<bool> DeleteLinesEmployeeTerminalAsync(int ID);
    }
}
