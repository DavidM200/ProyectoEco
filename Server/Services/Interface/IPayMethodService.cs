using GestionTelefonos.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface IPayMethodService
    {
        Task<IEnumerable<PayMethod>> GetPayMethodsAsync();
        Task<IEnumerable<PayMethod>> GetPayMethodsAsync(string observacion);

        Task SavePayMethodAsync(PayMethod payMethod);
        Task UpdatePayMethod(PayMethod payMethod);
        Task<bool> DeletePayMethod(int ID);

    }
}
