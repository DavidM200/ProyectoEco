using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetCompaniesAsync();
        Task<IEnumerable<Company>> GetCompaniesAsync(string observacion);
        Task<IEnumerable<Company>> GetCompaniesAsyncBuscador(CompanySearcherForm companyForm);

        Task SaveCompanyAsync(Company company);
        Task UpdateCompany(Company company);
        Task<bool> DeleteCompany(int ID);
    }
}
