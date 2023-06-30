using GestionTelefonos.Shared;
using System;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Client.Services
{
    public interface ICompanyService
    {
        Task<Company[]> Buscar(string observacion);
        Task<Company[]> BuscarForm(CompanySearcherForm companyForm);

        Task<Company[]> GetCompanies();

        Task InsertCompanyAsync(Company newCompany);

        Task UpdateCompanyAsync(Company editingCompany);

        Task<bool> DeleteCompanyAsync(int ID);
    }
}
