using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using GestionTelefonos.Shared.Contracts.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class SimService : ISimService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ISimRepository simRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public SimService(ISimRepository simRepository)
        {
            this.simRepository = simRepository;
        }

        public async Task<bool> DeleteSim(int ID)
        {
            return await simRepository.DeleteSim(ID);
        }

        public async Task<IEnumerable<Sim>> GetSimsAsync(string observacion)
        {
            return await simRepository.GetSimsAsync(observacion);
        }
        public async Task<IEnumerable<Sim>> GetSims2Async(SimSearcherForm simForm)
        {
            return await simRepository.GetSimsAsyncBuscador(simForm);
        }

        public async Task<IEnumerable<Sim>> GetSimsAsync()
        {
            return await simRepository.GetSimsAsync();
        }

        public async Task SaveSimAsync(Sim sim)
        {
            await simRepository.SaveSimAsync(sim);
        }

        public async Task UpdateSim(Sim sim)
        {
            await simRepository.UpdateSim(sim);
        }
    }
}
