using GestionTelefonos.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class PhoneIncidenceService : IPhoneIncidenceService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public PhoneIncidenceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PhoneIncidence[]> Buscar(string descripcion)
        {
            return await httpClient.GetFromJsonAsync<PhoneIncidence[]>($"api/PhoneIncidence/buscar/{descripcion}");
        }

        public async Task<bool> DeleteIncidenceAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/PhoneIncidence/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<PhoneIncidence[]> GetIncidents()
        {
            var list = await httpClient.GetFromJsonAsync<PhoneIncidence[]>("api/PhoneIncidence");
            return list;
        }

        public async Task InsertIncidenceAsync(PhoneIncidence newPhoneIncidence)
        {
            await httpClient.PostAsJsonAsync<PhoneIncidence>("api/PhoneIncidence", newPhoneIncidence);
        }

        public async Task UpdateIncidenceAsync(PhoneIncidence editingPhoneIncidence)
        {
            await httpClient.PutAsJsonAsync<PhoneIncidence>("api/PhoneIncidence", editingPhoneIncidence);
        }


    }
}
