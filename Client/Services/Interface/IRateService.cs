using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface IRateService
    {
        Task<Rate[]> Buscar(string observacion);
        Task<Rate[]> BuscarForm(RateSearcherForm rateForm);
        Task<Rate[]> GetRates();
        Task InsertRateAsync(Rate newRate);
        Task UpdateRateAsync(Rate editingRate);
        Task<bool> DeleteRateAsync(int ID);
    }
}
