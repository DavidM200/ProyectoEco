using GestionTelefonos.Shared;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface ILinesTerminalService
    {
        Task<LinesTerminal[]> Buscar(string consulta);
        Task<LinesTerminal[]> GetLinesTerminal();
        Task InsertLinesTerminalAsync(LinesTerminal newLinesTerminal);
        Task UpdateLinesTerminalAsync(LinesTerminal editingLinesTerminal);
        Task<bool> DeleteLinesTerminalAsync(int ID);
    }
}
