using GestionTelefonos.Shared;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface ILinesEmployeeTerminalService
    {
        Task<LinesEmployeeTerminal[]> Buscar(string consulta);
        Task<LinesEmployeeTerminal[]> GetLinesEmployeeTerminal();
        Task InsertLinesEmployeeTerminalAsync(LinesEmployeeTerminal newLinesEmployeeTerminal);
        Task UpdateLinesEmployeeTerminalAsync(LinesEmployeeTerminal editingLinesEmployeeTerminal);
        Task<bool> DeleteLinesEmployeeTerminalAsync(int ID);
    }
}
