using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface ILineService
    {
        Task<IEnumerable<Line>> GetLinesAsync();

        Task<IEnumerable<Line>> GetLinesAsync(string observacion);
        Task<IEnumerable<Line>> GetLines2Async(LineSearcherForm lineForm);

        Task SaveLineAsync(Line line);
        Task UpdateLine(Line line);
        Task<bool> DeleteLine(int ID);
    }
}
