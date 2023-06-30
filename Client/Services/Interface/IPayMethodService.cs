using GestionTelefonos.Shared;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface IPayMethodService
    {
        Task<PayMethod[]> Buscar(string nombre);
        Task<PayMethod[]> GetPayMethods();
        Task InsertPayMethodAsync(PayMethod payMethod);
        Task UpdatePayMethodAsync(PayMethod payMethod);
        Task<bool> DeletePayMethodAsync(int ID);
    }
}
