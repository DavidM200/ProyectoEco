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
    public class PhoneIncidenceRepository : IPhoneIncidenceRepository
    {
        private readonly string connectionString;

        public PhoneIncidenceRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }

        public async Task<bool> DeleteIncident(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM PhoneIncidents where ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public async Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM PhoneIncidents ORDER BY Description";
                return await db.QueryAsync<PhoneIncidence>(query).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<PhoneIncidence>> GetIncidentsAsync(string descripcion)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM PhoneIncidents WHERE IdTerminal LIKE @descripcion";
                return await db.QueryAsync<PhoneIncidence>(query, new { descripcion = $"%{descripcion}" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task SaveIncidenceAsync(PhoneIncidence phoneIncidence)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @"INSERT INTO PhoneIncidents(IdTerminal,IdEmployee,Description,Amount)
                      VALUES(@idterminal,@idemployee,@description,@amount)";
                await db.ExecuteAsync(query, new
                {
                    idterminal = phoneIncidence.IDTerminal,
                    idemployee = phoneIncidence.IDEmployee,
                    description = phoneIncidence.Description,
                    amount = phoneIncidence.Amount.ToString().Replace(",", "."),

                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdateIncidence(PhoneIncidence phoneIncidence)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @"UPDATE PhoneIncidents SET IdTerminal=@idterminal,
                IdEmployee=@idemployee,Description=@description,Amount=@amount WHERE ID = @id";
                await db.ExecuteAsync(query, new
                {
                    idterminal = phoneIncidence.IDTerminal,
                    idemployee = phoneIncidence.IDEmployee,
                    description = phoneIncidence.Description,
                    amount = phoneIncidence.Amount.ToString().Replace(",", "."),
                    id = phoneIncidence.ID
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
