using GestionTelefonos.Shared;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface IPhoneIncidenceService
    {
        Task<PhoneIncidence[]> Buscar(string descripcion);
        Task<PhoneIncidence[]> GetIncidents();
        Task InsertIncidenceAsync(PhoneIncidence newPhoneIncidence);
        Task UpdateIncidenceAsync(PhoneIncidence editingPhoneIncidence);
        Task<bool> DeleteIncidenceAsync(int ID);
    }
}
