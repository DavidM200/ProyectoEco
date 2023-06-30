using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public class CompanyService : ICompanyService
    {
        HttpClient httpClient;
        public CompanyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Company[]> Buscar(string nombre)
        {
            return await httpClient.GetFromJsonAsync<Company[]>($"api/Company/buscar/{nombre}");
        }
        public async Task<Company[]> BuscarForm(CompanySearcherForm companyForm)
        {
              var a = await httpClient.PostAsJsonAsync<CompanySearcherForm>("api/Company/buscar", companyForm);
            if (a.IsSuccessStatusCode) {
                return await a.Content.ReadFromJsonAsync<Company[]>();
            }
            else
            {
                Console.WriteLine("Error Company Services Client");
                return null;
            }
                
            
        }
        public async Task<bool> DeleteCompanyAsync(int ID)
        {
            var result = await httpClient.DeleteAsync("api/Company/" + ID.ToString());
            return result.IsSuccessStatusCode;
        }
        public async Task<Company[]> GetCompanies()
        {
            var list = await httpClient.GetFromJsonAsync<Company[]>("api/Company");
            return list;
        }
        public async Task InsertCompanyAsync(Company newCompany)
        {
            await httpClient.PostAsJsonAsync<Company>("api/Company", newCompany);
        }
        public async Task UpdateCompanyAsync(Company editingCompany)
        {
            await httpClient.PutAsJsonAsync<Company>("api/Company", editingCompany);
        }
    }
}