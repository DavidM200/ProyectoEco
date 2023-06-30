using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class TerminalService : ITerminalService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public TerminalService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Terminal[]> Buscar(string observacion)
        {
            return await httpClient.GetFromJsonAsync<Terminal[]>($"api/Terminal/buscar/{observacion}");
        }
        public async Task<Terminal[]> BuscarForm(TerminalSearcherForm terminalForm)
        {
            var a = await httpClient.PostAsJsonAsync<TerminalSearcherForm>($"api/Terminal/buscar", terminalForm);
            if (a.IsSuccessStatusCode)
            {
                return await a.Content.ReadFromJsonAsync<Terminal[]>();
            }
            else
            {
                Console.WriteLine("Error Terminal Service Client");
                return null;
            }

        }
        public async Task<bool> DeleteTerminalAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/Terminal/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<Terminal[]> GetTerminals()
        {
            var list = await httpClient.GetFromJsonAsync<Terminal[]>("api/Terminal");
            return list;
        }

        public async Task InsertTerminalAsync(Terminal newTerminal)
        {

            await httpClient.PostAsJsonAsync<Terminal>("api/Terminal", newTerminal);
        }

        public async Task UpdateTerminalAsync(Terminal editingTerminal)
        {
            await httpClient.PutAsJsonAsync<Terminal>("api/Terminal", editingTerminal);
        }
    }
}
