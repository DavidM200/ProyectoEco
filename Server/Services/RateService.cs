using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using GestionTelefonos.Shared.Contracts.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class RateService : IRateService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IRateRepository rateRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public RateService(IRateRepository rateRepository)
        {
            this.rateRepository = rateRepository;
        }
        public async Task<bool> DeleteRate(int ID)
        {
            return await rateRepository.DeleteRate(ID);
        }
        public async Task<IEnumerable<Rate>> GetRatesAsync()
        {
            return await rateRepository.GetRatesAsync();
        }
        public async Task<IEnumerable<Rate>> GetRatesAsync(string nombre)
        {
            return await rateRepository.GetRatesAsync(nombre);
        }
        public async Task<IEnumerable<Rate>> GetRates2Async(RateSearcherForm rateForm)
        {
            return await rateRepository.GetRatesAsyncBuscador(rateForm);
        }
        public async Task SaveRateAsync(Rate rate)
        {
            await rateRepository.SaveRateAsync(rate);
        }
        public async Task UpdateRate(Rate rate)
        {
            await rateRepository.UpdateRate(rate);
        }
    }
}
