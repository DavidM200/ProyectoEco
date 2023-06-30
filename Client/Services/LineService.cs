using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class LineService : ILineService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LineService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Line[]> Buscar(string observacion)
        {
            return await httpClient.GetFromJsonAsync<Line[]>($"api/Line/buscar/{observacion}");
        }
        public async Task<Line[]> BuscarForm(LineSearcherForm lineForm)
        {
            

            var a = await httpClient.PostAsJsonAsync<LineSearcherForm>($"api/Line/buscar",lineForm);
            if (a.IsSuccessStatusCode)
            {
                return await a.Content.ReadFromJsonAsync<Line[]>();
            }
            else
            {
                Console.WriteLine("Error Line Service Client");
                return null;
            }
        }

        public async Task<bool> DeleteLineAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/Line/" + ID.ToString());

            // Comprobar si se eliminó

            // Comprobar código específico
            //if(result.StatusCode == System.Net.HttpStatusCode.BadRequest){}

            // O comprobar si es Ok()
            return result.IsSuccessStatusCode;
        }
        public async Task<Line[]> GetLines()
        {
            var list = await httpClient.GetFromJsonAsync<Line[]>("api/Line");
            return list;
        }
        public async Task InsertLineAsync(Line newLine)
        {
            await httpClient.PostAsJsonAsync<Line>("api/Line", newLine);
        }
        public async Task UpdateLineAsync(Line editingLine)
        {
            await httpClient.PutAsJsonAsync<Line>("api/Line", editingLine);
        }
    }
}
