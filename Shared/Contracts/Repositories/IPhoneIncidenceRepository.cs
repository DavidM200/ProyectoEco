using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface IPhoneIncidenceRepository
    {
        Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync();
        Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync(string descripcion);
        Task SaveIncidenceAsync(PhoneIncidence phoneIncidence);
        Task UpdateIncidence(PhoneIncidence phoneIncidence);
        Task<bool> DeleteIncident(int ID);

    }
}
