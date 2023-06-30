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

    public class LinesEmployeeTerminalRepository : ILinesEmployeeTerminalRepository
    {
        private readonly string connectionString;
        public LinesEmployeeTerminalRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }

        public async Task<bool> DeleteLinesEmployeeTerminalAsync(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM LinesEmployeeTerminal where ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeeTerminalsAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM LinesEmployeeTerminal";
                return await db.QueryAsync<LinesEmployeeTerminal>(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<LinesEmployeeTerminal>> GetLinesEmployeeTerminalsAsync(string consulta)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM LinesEmployeeTerminal WHERE IDEmployee LIKE @consulta";
                return await db.QueryAsync<LinesEmployeeTerminal>(query, new { consulta = $"%{consulta}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task SaveLinesEmployeeTerminalAsync(LinesEmployeeTerminal linesEmployeeTerminal)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                    @"INSERT INTO
                            LinesEmployeeTerminal (IDLine, IDEmployee, IDTerminal)
                            VALUES (@idline, @idemployee, @idterminal)";

                await db.ExecuteAsync(query,
                    new
                    {
                        idline = linesEmployeeTerminal.IDLine,
                        idemployee = linesEmployeeTerminal.IDEmployee,
                        idterminal = linesEmployeeTerminal.IDTerminal,

                    });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdateLinesEmployeeTerminal(LinesEmployeeTerminal linesEmployeeTerminal)
        {
            try
            {

                using IDbConnection db = new SqlConnection(connectionString);

                string query = @"UPDATE LinesEmployeeTerminal 
                     SET IDLine = @idline,IDEmployee = @idemployee, IDTerminal = @idterminal WHERE ID = @id";
                await db.ExecuteAsync(query,
                new
                {
                    idline = linesEmployeeTerminal.IDLine,
                    idemployee = linesEmployeeTerminal.IDEmployee,
                    idterminal = linesEmployeeTerminal.IDTerminal,
                    id = linesEmployeeTerminal.ID

                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
