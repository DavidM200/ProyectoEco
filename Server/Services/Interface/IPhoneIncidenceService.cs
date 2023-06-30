using GestionTelefonos.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface IPhoneIncidenceService
    {
        Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync();
        Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync(string descripcion);
        Task SaveIncidenceAsync(PhoneIncidence phoneIncidence);
        Task UpdateIncidence(PhoneIncidence phoneIncidence);
        Task<bool> DeleteIncidence(int ID);
    }
}
