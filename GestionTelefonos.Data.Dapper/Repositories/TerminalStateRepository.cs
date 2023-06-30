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
    public class TerminalStateRepository : ITerminalStateRepository
    {
        private readonly string connectionString;
        public TerminalStateRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeleteTerminalState(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM TerminalState WHERE ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<TerminalState>> GetTerminalStatesAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM TerminalState ORDER BY Name";
                return await db.QueryAsync<TerminalState>(query).ConfigureAwait(false);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<TerminalState>> GetTerminalStatesAsync(string nombre)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM TerminalState WHERE Name LIKE @nombre";
                return await db.QueryAsync<TerminalState>(query, new { nombre = $"%{nombre}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task SaveTerminalStateAsync(TerminalState terminalState)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                @"INSERT INTO TerminalState(Name) VALUES (@name)";
                await db.ExecuteAsync(query, new
                {
                    name = terminalState.Name
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdateTerminalState(TerminalState terminalState)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @"UPDATE TerminalState SET Name =@name  WHERE ID =@id";
                await db.ExecuteAsync(query, new
                {
                    name = terminalState.Name,
                    id = terminalState.ID
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
