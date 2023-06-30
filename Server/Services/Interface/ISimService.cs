using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface ISimService
    {
        Task<IEnumerable<Sim>> GetSimsAsync();
        Task<IEnumerable<Sim>> GetSimsAsync(string observacion);
        Task<IEnumerable<Sim>> GetSims2Async(SimSearcherForm simForm);
        Task SaveSimAsync(Sim sim);
        Task UpdateSim(Sim sim);
        Task<bool> DeleteSim(int ID);

    }
}
