using GestionTelefonos.Shared;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface ITerminalStateService
    {
        Task<TerminalState[]> Buscar(string nombre);

        Task<TerminalState[]> GetTerminalStates();

        Task InsertTerminalStateAsync(TerminalState newTerminalState);

        Task UpdateTerminalStateAsync(TerminalState editingTerminalState);

        Task<bool> DeleteTerminalStateAsync(int ID);
    }
}
