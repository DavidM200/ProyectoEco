using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ISimRepository
    {
        Task<IEnumerable<Sim>> GetSimsAsync();
        Task<IEnumerable<Sim>> GetSimsAsync(string observacion);
        Task<IEnumerable<Sim>> GetSimsAsyncBuscador(SimSearcherForm simForm);
        Task SaveSimAsync(Sim sim);
        Task UpdateSim(Sim sim);
        Task<bool> DeleteSim(int iD);
    }
}
