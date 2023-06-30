using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface ISimService
    {
        Task<Sim[]> Buscar(string observacion);
        Task<Sim[]> BuscarForm(SimSearcherForm simForm);
        Task<Sim[]> GetSims();
        Task InsertSimAsync(Sim newSim);
        Task UpdateSimAsync(Sim editingSim);
        Task<bool> DeleteSimAsync(int ID);

    }
}
