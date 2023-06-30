using GestionTelefonos.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;
namespace GestionTelefonos.Client.Services
{
    public interface ILineService
    {

        Task<Line[]> Buscar(string observacion);
        Task<Line[]> BuscarForm(LineSearcherForm lineForm);

        Task<Line[]> GetLines();

        Task InsertLineAsync(Line newLine);

        Task UpdateLineAsync(Line editingLine);

        Task<bool> DeleteLineAsync(int ID);
    }
}
