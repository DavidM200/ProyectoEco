using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class PayMethodService : IPayMethodService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IPayMethodRepository payMethodRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public PayMethodService(IPayMethodRepository payMethodRepository)
        {
            this.payMethodRepository = payMethodRepository;
        }
        public async Task<bool> DeletePayMethod(int ID)
        {
            return await payMethodRepository.DeletePayMethod(ID);
        }

        public async Task<IEnumerable<PayMethod>> GetPayMethodsAsync()
        {
            return await payMethodRepository.GetPayMethodsAsync();
        }

        public async Task<IEnumerable<PayMethod>> GetPayMethodsAsync(string observacion)
        {
            return await payMethodRepository.GetPayMethodsAsync(observacion);
        }

        public async Task SavePayMethodAsync(PayMethod payMethod)
        {
            await payMethodRepository.SavePayMethodAsync(payMethod);
        }

        public async Task UpdatePayMethod(PayMethod payMethod)
        {
            await payMethodRepository.UpdatePayMethod(payMethod);
        }
    }
}
