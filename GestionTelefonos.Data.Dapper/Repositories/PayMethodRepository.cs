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
    public class PayMethodRepository : IPayMethodRepository
    {
        private readonly string connectionString;

        public PayMethodRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeletePayMethod(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM PayMethod WHERE ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<PayMethod>> GetPayMethodsAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM PayMethod ORDER BY Name";
                return await db.QueryAsync<PayMethod>(query).ConfigureAwait(false);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<PayMethod>> GetPayMethodsAsync(string nombre)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM PayMethod WHERE Name LIKE @nombre";
                return await db.QueryAsync<PayMethod>(query, new { nombre = $"%{nombre}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task SavePayMethodAsync(PayMethod payMethod)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                @"INSERT INTO PayMethod(Name) VALUES (@name)";
                await db.ExecuteAsync(query, new
                {
                    name = payMethod.Name
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdatePayMethod(PayMethod payMethod)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @"UPDATE PayMethod SET Name =@name WHERE ID =@id";
                await db.ExecuteAsync(query, new
                {
                    name = payMethod.Name,
                    id = payMethod.ID
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
