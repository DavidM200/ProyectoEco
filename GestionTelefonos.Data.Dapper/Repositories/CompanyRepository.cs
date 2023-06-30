using Dapper;
using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using GestionTelefonos.Shared.Contracts.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GestionTelefonos.Data.Dapper.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly string connectionString;

        public CompanyRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeleteCompany(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM Companies WHERE ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Companies ORDER BY Name";
                return await db.QueryAsync<Company>(query).ConfigureAwait(false);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Company>> GetCompaniesAsync(string nombre)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Companies WHERE Name LIKE @nombre";
                return await db.QueryAsync<Company>(query, new { nombre = $"%{nombre}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Company>> GetCompaniesAsyncBuscador(CompanySearcherForm companyForm)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @$"
                            SELECT
                                * 
                            FROM 
                                Companies 
                            WHERE 
                                1=1
                                {(companyForm.Name==null ? "" : "AND Name like @nombre")}
                                {(companyForm.AdmitDateInicio==null && companyForm.AdmitDateFin==null ? "" : "AND AdmitDate BETWEEN @admitdateinicio AND @admitdatefin")}
                                {(companyForm.DischargeDateInicio==null && companyForm.DischargeDateFin==null ? "" : "AND DischargeDate BETWEEN @dischargedateinicio AND @dischargedatefin")}
                        
                        ";
                return await db.QueryAsync<Company>(query, new
                {
                    nombre = $"%{companyForm.Name}%",
                    admitdateinicio = companyForm.AdmitDateInicio,
                    admitdatefin = companyForm.AdmitDateFin,
                    dischargedateinicio = companyForm.DischargeDateInicio,
                    dischargedatefin = companyForm.DischargeDateFin
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public async Task SaveCompanyAsync(Company company)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                @"INSERT INTO Companies(Name,AdmitDate,DischargeDate) VALUES (@name,@admitdate, @dischargedate)";
                await db.ExecuteAsync(query, new
                {
                    name = company.Name,
                    admitdate = company.AdmitDate,
                    dischargedate = company.DischargeDate
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task UpdateCompany(Company company)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @"UPDATE Companies SET Name =@name,AdmitDate = @admitdate,DischargeDate = @dischargedate  WHERE ID =@id";
                await db.ExecuteAsync(query, new
                {
                    name = company.Name,
                    admitdate = company.AdmitDate,
                    dischargedate = company.DischargeDate,
                    id = company.ID
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
