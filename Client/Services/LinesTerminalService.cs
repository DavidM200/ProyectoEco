using GestionTelefonos.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class LinesTerminalService : ILinesTerminalService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LinesTerminalService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<LinesTerminal[]> Buscar(string consulta)
        {
            return await httpClient.GetFromJsonAsync<LinesTerminal[]>($"api/LinesTerminal/buscar/{consulta}");
        }

        public async Task<bool> DeleteLinesTerminalAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/LinesTerminal/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<LinesTerminal[]> GetLinesTerminal()
        {
            var list = await httpClient.GetFromJsonAsync<LinesTerminal[]>("api/LinesTerminal");
            return list;
        }

        public async Task InsertLinesTerminalAsync(LinesTerminal newLinesTerminal)
        {
            await httpClient.PostAsJsonAsync<LinesTerminal>("api/LinesTerminal", newLinesTerminal);
        }

        public async Task UpdateLinesTerminalAsync(LinesTerminal editingLinesTerminal)
        {
            await httpClient.PutAsJsonAsync<LinesTerminal>("api/LinesTerminal", editingLinesTerminal);
        }
    }
}
