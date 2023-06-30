using Dapper;
using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using GestionTelefonos.Shared.Contracts.Forms;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GestionTelefonos.Data.Dapper.Repositories
{
    public class RateRepository : IRateRepository
    {
        private readonly string connectionString;

        public RateRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeleteRate(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM Rates where ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public async Task<IEnumerable<Rate>> GetRatesAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Rates ORDER BY Name";
                return await db.QueryAsync<Rate>(query).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Rate>> GetRatesAsync(string nombre)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Rates WHERE Name LIKE @nombre";
                return await db.QueryAsync<Rate>(query, new { nombre = $"%{nombre}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Rate>> GetRatesAsyncBuscador(RateSearcherForm rateForm)
        {
            if (rateForm.OperacionAmount == "<=" || rateForm.OperacionAmount == "=" || rateForm.OperacionAmount == ">=" || rateForm.OperacionAmount == null && rateForm.OperacionDiscount == "<="  ||
                rateForm.OperacionDiscount == "=" || rateForm.OperacionDiscount == ">=" || rateForm.OperacionDiscount == null && rateForm.OperacionMonthlyNetAmount == "<=" || rateForm.OperacionMonthlyNetAmount == "="
                || rateForm.OperacionMonthlyNetAmount == ">=" || rateForm.OperacionMonthlyNetAmount == null)
            {
                try
                {
                    using IDbConnection db = new SqlConnection(connectionString);

                    string query = @$"
                                SELECT
                                    * 
                                FROM 
                                    Rates 
                                WHERE 
                                    1=1
                                    {(string.IsNullOrEmpty(rateForm.Name) ? "" : "AND Name LIKE @name ")}
                                    {(rateForm.CompanyIds.Count == 0 ? "" : "AND IDCompany IN @companyId ")}
                                    {(rateForm.Amount == null ? "" : "AND Amount " + rateForm.OperacionAmount + " @amount ")}
                                    {(rateForm.Discount == null ? "" : "AND Discount " + rateForm.OperacionDiscount + " @discount ")}
                                    {(rateForm.MonthlyNetAmount == null ? "" : " AND MonthlyNetAmount " + rateForm.OperacionMonthlyNetAmount + " @monthlynetamount")}
                            ";
                    //var listIds = System.Text.Json.JsonSerializer.Deserialize<List<int>>(rateForm.CompanyIds);
                    //int companyId;
                    Console.WriteLine(query);
                    return await db.QueryAsync<Rate>(query, new
                    {
                        name = $"%{rateForm.Name}%",
                        companyId = rateForm.CompanyIds,
                        amount = rateForm.Amount.ToString().Replace(",", "."),
                        discount = rateForm.Discount.ToString().Replace(",", "."),
                        monthlynetamount = rateForm.MonthlyNetAmount.ToString().Replace(",", "."),
                    });

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                    
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Operadores no validos");
                return null;
            }
        }

        public async Task SaveRateAsync(Rate rate)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @"INSERT INTO 
                    Rates(Name,IDCompany,Amount,Discount,MonthlyNetAmount) VALUES (@name,@idcompany, @amount,@discount,@monthlynetamount)";
                await db.ExecuteAsync(query, new
                {
                    name = rate.Name,
                    idcompany = rate.IDCompany,
                    amount = rate.Amount.ToString().Replace(",", "."),
                    discount = rate.Discount.ToString().Replace(",", "."),
                    monthlynetamount = rate.MonthlyNetAmount.ToString().Replace(",", ".")
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task UpdateRate(Rate rate)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);

                string query = @"UPDATE Rates SET Name =@name ,IDCompany = @idcompany, Amount =@amount ,Discount =@discount,MonthlyNetAmount = @monthlynetamount  WHERE ID = @id ";
                await db.ExecuteAsync(query, new
                {
                    name = rate.Name,
                    idcompany = rate.IDCompany,
                    amount = rate.Amount.ToString().Replace(",", "."),
                    discount = rate.Discount.ToString().Replace(",", "."),
                    monthlynetamount = rate.MonthlyNetAmount.ToString().Replace(",", "."),
                    id = rate.ID
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

