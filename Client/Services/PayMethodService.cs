using GestionTelefonos.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class PayMethodService : IPayMethodService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public PayMethodService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<PayMethod[]> Buscar(string nombre)
        {
            return await httpClient.GetFromJsonAsync<PayMethod[]>($"api/PayMethod/buscar/{nombre}");
        }

        public async Task<bool> DeletePayMethodAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/PayMethod/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<PayMethod[]> GetPayMethods()
        {
            var list = await httpClient.GetFromJsonAsync<PayMethod[]>("api/PayMethod");
            return list;
        }

        public async Task InsertPayMethodAsync(PayMethod newPayMethod)
        {
            await httpClient.PostAsJsonAsync<PayMethod>("api/PayMethod", newPayMethod);
        }

        public async Task UpdatePayMethodAsync(PayMethod editingPayMethod)
        {
            await httpClient.PutAsJsonAsync<PayMethod>("api/PayMethod", editingPayMethod);
        }
    }
}
