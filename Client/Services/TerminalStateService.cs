using GestionTelefonos.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class TerminalStateService : ITerminalStateService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public TerminalStateService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<TerminalState[]> Buscar(string nombre)
        {
            return await httpClient.GetFromJsonAsync<TerminalState[]>($"api/TerminalState/buscar/{nombre}");
        }

        public async Task<bool> DeleteTerminalStateAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/TerminalState/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<TerminalState[]> GetTerminalStates()
        {
            var list = await httpClient.GetFromJsonAsync<TerminalState[]>("api/TerminalState");
            return list;
        }

        public async Task InsertTerminalStateAsync(TerminalState newTerminalState)
        {
            await httpClient.PostAsJsonAsync<TerminalState>("api/TerminalState", newTerminalState);
        }

        public async Task UpdateTerminalStateAsync(TerminalState editingTerminalState)
        {
            await httpClient.PutAsJsonAsync<TerminalState>("api/TerminalState", editingTerminalState);
        }
    }
}
