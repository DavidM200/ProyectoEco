using GestionTelefonos.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class LinesEmployeeTerminalService : ILinesEmployeeTerminalService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LinesEmployeeTerminalService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<LinesEmployeeTerminal[]> Buscar(string consulta)
        {
            return await httpClient.GetFromJsonAsync<LinesEmployeeTerminal[]>($"api/LinesEmployeeTerminal/buscar/{consulta}");
        }

        public async Task<bool> DeleteLinesEmployeeTerminalAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/LinesEmployeeTerminal/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<LinesEmployeeTerminal[]> GetLinesEmployeeTerminal()
        {
            var list = await httpClient.GetFromJsonAsync<LinesEmployeeTerminal[]>("api/LinesEmployeeTerminal");
            return list;
        }

        public async Task InsertLinesEmployeeTerminalAsync(LinesEmployeeTerminal newLinesEmployeeTerminal)
        {
            await httpClient.PostAsJsonAsync<LinesEmployeeTerminal>("api/LinesEmployeeTerminal", newLinesEmployeeTerminal);
        }

        public async Task UpdateLinesEmployeeTerminalAsync(LinesEmployeeTerminal editingLinesEmployeeTerminal)
        {
            await httpClient.PutAsJsonAsync<LinesEmployeeTerminal>("api/LinesEmployeeTerminal", editingLinesEmployeeTerminal);
        }
    }
}
