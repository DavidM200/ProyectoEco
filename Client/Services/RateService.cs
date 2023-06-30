using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class RateService : IRateService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public RateService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Rate[]> Buscar(string nombre)
        {
            return await httpClient.GetFromJsonAsync<Rate[]>($"api/Rate/buscar/{nombre}");
        }
        public async Task<Rate[]> BuscarForm(RateSearcherForm rateForm) 
        {
            String json = JsonSerializer.Serialize(rateForm);
            Console.WriteLine(json);
                var a = await httpClient.PostAsJsonAsync<RateSearcherForm>($"api/Rate/buscar", rateForm);
                if (a.IsSuccessStatusCode)
                {
                    return await a.Content.ReadFromJsonAsync<Rate[]>();
                }
                else
                {
                    Console.WriteLine("Error Rate Service Client");
                    return null;
                }
            
        }
        public async Task<bool> DeleteRateAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/Rate/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }
        public async Task<Rate[]> GetRates()
        {
            var list = await httpClient.GetFromJsonAsync<Rate[]>("api/Rate");
            return list;
        }
        public async Task InsertRateAsync(Rate newRate)
        {
            await httpClient.PostAsJsonAsync<Rate>("api/Rate", newRate);
        }
        public async Task UpdateRateAsync(Rate editingRate)
        {
            await httpClient.PutAsJsonAsync<Rate>("api/Rate", editingRate);
        }
    }
}
