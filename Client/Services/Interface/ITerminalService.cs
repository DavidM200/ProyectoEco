using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Threading.Tasks;


namespace GestionTelefonos.Client.Services
{
    public interface ITerminalService
    {
        Task<Terminal[]> Buscar(string observacion);

        Task<Terminal[]> GetTerminals();
        Task<Terminal[]> BuscarForm(TerminalSearcherForm terminalForm);

        Task InsertTerminalAsync(Terminal newTerminal);

        Task UpdateTerminalAsync(Terminal editingTerminal);

        Task<bool> DeleteTerminalAsync(int ID);
    }
}
