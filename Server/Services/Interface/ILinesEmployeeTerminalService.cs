using GestionTelefonos.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface ILinesEmployeeTerminalService
    {
        Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeesTerminalsAsync();
        Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeesTerminalsAsync(string consulta);
        Task SaveLinesEmployeeTerminal(LinesEmployeeTerminal linesEmployeeTerminal);
        Task UpdateLinesEmployeeTerminal(LinesEmployeeTerminal linesEmployeeTerminal);
        Task<bool> DeleteLinesEmployeeTerminal(int ID);
    }
}
