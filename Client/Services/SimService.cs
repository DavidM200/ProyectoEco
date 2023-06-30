using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace GestionTelefonos.Client.Services
{

    public class SimService : ISimService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public SimService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Sim[]> Buscar(string tipo)
        {
            return await httpClient.GetFromJsonAsync<Sim[]>($"api/Sim/buscar/{tipo}");
        }
        public async Task<Sim[]> BuscarForm(SimSearcherForm simForm)
        {
            try
            {

                var a = await httpClient.PostAsJsonAsync<SimSearcherForm>($"api/Sim/buscar",simForm);
                if (a.IsSuccessStatusCode)
                {
                    return await a.Content.ReadFromJsonAsync<Sim[]>();
                }
                else
                {
                    Console.WriteLine("Error Sim Service Client");
                    return null;
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<bool> DeleteSimAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/Sim/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<Sim[]> GetSims()
        {
            var list = await httpClient.GetFromJsonAsync<Sim[]>("api/Sim");
            return list;
        }

        public async Task InsertSimAsync(Sim newSim)
        {
            await httpClient.PostAsJsonAsync<Sim>("api/Sim", newSim);
        }

        public async Task UpdateSimAsync(Sim editingSim)
        {
            await httpClient.PutAsJsonAsync<Sim>("api/Sim", editingSim);
        }
    }
}
