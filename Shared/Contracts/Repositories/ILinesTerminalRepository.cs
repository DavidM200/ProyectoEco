using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ILinesTerminalRepository
    {
        Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync();
        Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync(string consulta);
        Task SaveLinesTerminalAsync(LinesTerminal linesTerminal);
        Task UpdateLinesTerminal(LinesTerminal linesTerminal);
        Task<bool> DeleteLinesTerminalAsync(int ID);
    }
}
