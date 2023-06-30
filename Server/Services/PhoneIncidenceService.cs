using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class PhoneIncidenceService : IPhoneIncidenceService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IPhoneIncidenceRepository incidenceRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public PhoneIncidenceService(IPhoneIncidenceRepository incidenceRepository)
        {
            this.incidenceRepository = incidenceRepository;
        }
        public async Task<bool> DeleteIncidence(int ID)
        {
            return await incidenceRepository.DeleteIncident(ID);
        }
        public async Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync(string descripcion)
        {
            return await incidenceRepository.GetIncidentsAsync(descripcion);
        }
        public async Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync()
        {
            return await incidenceRepository.GetIncidentsAsync();
        }
        public async Task SaveIncidenceAsync(PhoneIncidence phoneIncidence)
        {
            await incidenceRepository.SaveIncidenceAsync(phoneIncidence);
        }

        public async Task UpdateIncidence(PhoneIncidence phoneIncidence)
        {
            await incidenceRepository.UpdateIncidence(phoneIncidence);
        }
    }
}
