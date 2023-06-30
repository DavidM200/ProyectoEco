using Dapper;
using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace GestionTelefonos.Data.Dapper.Repositories
{
    public class LinesEmployeeRepository : ILinesEmployeeRepository
    {
        private readonly string connectionString;

        public LinesEmployeeRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeleteLinesEmployeeAsync(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM LinesEmployee where ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM LinesEmployee";
                return await db.QueryAsync<LinesEmployee>(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync(string consulta)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM LinesEmployee WHERE IDEmployee LIKE @consulta";
                return await db.QueryAsync<LinesEmployee>(query, new { consulta = $"%{consulta}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public async Task SaveLinesEmployeeAsync(LinesEmployee linesEmployee)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                    @"INSERT INTO
                            LinesEmployee (IDLine, IDEmployee, StartDate, FinishDate)
                            VALUES (@idline, @idemployee, @startdate, @finishdate)";

                await db.ExecuteAsync(query,
                    new
                    {
                        idline = linesEmployee.IDLine,
                        idemployee = linesEmployee.IDEmployee,
                        startdate = linesEmployee.StartDate,
                        finishdate = linesEmployee.FinishDate

                    });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdateLinesEmployee(LinesEmployee linesEmployee)
        {
            try
            {

                using IDbConnection db = new SqlConnection(connectionString);

                string query = @"UPDATE LinesEmployee 
                     SET IDLine = @idline,IDEmployee = @idemployee, StartDate = @startdate,FinishDate = @finishdate WHERE ID = @id";
                await db.ExecuteAsync(query,
                new
                {
                    idline = linesEmployee.IDLine,
                    idemployee = linesEmployee.IDEmployee,
                    startdate = linesEmployee.StartDate,
                    finishdate = linesEmployee.FinishDate,
                    id = linesEmployee.ID

                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
