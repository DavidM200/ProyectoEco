using GestionTelefonos.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;



namespace GestionTelefonos.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        HttpClient httpClient;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee[]> Buscar(string nombre)
        {

            return await httpClient.GetFromJsonAsync<Employee[]>($"api/Employee/buscar/{nombre}");

        }
        public async Task<Employee[]> BuscarForm(string nombre)
        {
            return await httpClient.GetFromJsonAsync<Employee[]>($"api/Employee/buscar/{nombre}");
        }

        public async Task<bool> DeleteEmployeeAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/Employee/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }

        public async Task<Employee[]> GetEmployees()
        {
            var list = await httpClient.GetFromJsonAsync<Employee[]>("api/Employee");
            return list;
        }

        public async Task InsertEmployeeAsync(Employee newEmployee)
        {
            await httpClient.PostAsJsonAsync<Employee>("api/Employee", newEmployee);
        }

        public async Task UpdateEmployeeAsync(Employee editingEmployee)
        {
            await httpClient.PutAsJsonAsync<Employee>("api/Employee", editingEmployee);
        }
    }
}
