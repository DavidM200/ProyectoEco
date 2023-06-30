using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ILineRepository
    {
        Task<IEnumerable<Line>> GetLinesAsync();
        Task<IEnumerable<Line>> GetLinesAsync(string observacion);
        Task<IEnumerable<Line>> GetLinesAsyncBuscador(LineSearcherForm lineForm);

        Task SaveLineAsync(Line line);
        Task UpdateLine(Line line);
        Task<bool> DeleteLine(int ID);
    }
}
