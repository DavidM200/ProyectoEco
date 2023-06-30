using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using GestionTelefonos.Shared.Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class CompanyService : ICompanyService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ICompanyRepository companyRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }
        public async Task<bool> DeleteCompany(int ID)
        {
            return await companyRepository.DeleteCompany(ID);
        }
        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            return await companyRepository.GetCompaniesAsync();
        }
        public async Task<IEnumerable<Company>> GetCompaniesAsync(string observacion)
        {
            return await companyRepository.GetCompaniesAsync(observacion);
        }
        public async Task<IEnumerable<Company>> GetCompanies2Async(CompanySearcherForm companyForm)
        {
            return await companyRepository.GetCompaniesAsyncBuscador(companyForm);
        }
        public async Task SaveCompanyAsync(Company company)
        {
            await companyRepository.SaveCompanyAsync(company);
        }
        public async Task UpdateCompany(Company company)
        {
            await companyRepository.UpdateCompany(company);
        }
    }
}