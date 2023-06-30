using GestionTelefonos.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class LinesEmployeeService : ILinesEmployeeService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LinesEmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<LinesEmployee[]> Buscar(string consulta)
        {
            return await httpClient.GetFromJsonAsync<LinesEmployee[]>($"api/LinesEmployee/buscar/{consulta}");
        }
        public async Task<bool> DeleteLinesEmployeesAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/LinesEmployee/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<LinesEmployee[]> GetLinesEmployee()
        {
            var list = await httpClient.GetFromJsonAsync<LinesEmployee[]>("api/LinesEmployee");
            return list;
        }

        public async Task InsertLinesEmployeesAsync(LinesEmployee newLinesEmployee)
        {
            await httpClient.PostAsJsonAsync<LinesEmployee>("api/LinesEmployee", newLinesEmployee);
        }

        public async Task UpdateLinesEmployeesAsync(LinesEmployee editingLinesEmployee)
        {
            await httpClient.PutAsJsonAsync<LinesEmployee>("api/LinesEmployee", editingLinesEmployee);
        }
    }
}
