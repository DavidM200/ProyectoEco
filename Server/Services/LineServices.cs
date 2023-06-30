using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class LineService : ILineService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ILineRepository lineRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public LineService(ILineRepository lineRepository)
        {
            this.lineRepository = lineRepository;
        }

        public async Task<bool> DeleteLine(int ID)
        {
            return await lineRepository.DeleteLine(ID);
        }


        public async Task<IEnumerable<Line>> GetLinesAsync()
        {
            return await lineRepository.GetLinesAsync();
        }

        public async Task<IEnumerable<Line>> GetLinesAsync(string observacion)
        {
            return await lineRepository.GetLinesAsync(observacion);
        }
        public async Task<IEnumerable<Line>> GetLines2Async(LineSearcherForm lineForm)
        {
            return await lineRepository.GetLinesAsyncBuscador(lineForm );
        }

        public async Task SaveLineAsync(Line line)
        {
            await lineRepository.SaveLineAsync(line);
        }

        public async Task UpdateLine(Line line)
        {
            await lineRepository.UpdateLine(line);
        }
    }
}
