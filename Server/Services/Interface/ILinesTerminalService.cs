using GestionTelefonos.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface ILinesTerminalService
    {
        Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync();
        Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync(string consulta);
        Task SaveLinesTerminal(LinesTerminal linesTerminal);
        Task UpdateLinesTerminal(LinesTerminal linesTerminal);
        Task<bool> DeleteLinesTerminal(int ID);
    }
}
