using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface IRateRepository
    {
        Task<IEnumerable<Rate>> GetRatesAsync();
        Task<IEnumerable<Rate>> GetRatesAsync(string observacion);
        Task<IEnumerable<Rate>> GetRatesAsyncBuscador(RateSearcherForm rateForm);
        Task SaveRateAsync(Rate rate);
        Task UpdateRate(Rate rate);
        Task<bool> DeleteRate(int ID);
        
    }
}
