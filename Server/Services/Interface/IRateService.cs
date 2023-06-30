using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface IRateService
    {
        Task<IEnumerable<Rate>> GetRatesAsync();

        Task<IEnumerable<Rate>> GetRatesAsync(string observacion);
        Task<IEnumerable<Rate>> GetRates2Async(RateSearcherForm rateForm);
        Task SaveRateAsync(Rate rate);
        Task UpdateRate(Rate rate);
        Task<bool> DeleteRate(int ID);
    }
}
