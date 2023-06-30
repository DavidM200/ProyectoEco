using GestionTelefonos.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Server.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetCompaniesAsync();

        Task<IEnumerable<Company>> GetCompaniesAsync(string observacion);
        Task<IEnumerable<Company>> GetCompanies2Async(CompanySearcherForm companyForm);

        Task SaveCompanyAsync(Company company);
        Task UpdateCompany(Company company);
        Task<bool> DeleteCompany(int ID);
    }
}
