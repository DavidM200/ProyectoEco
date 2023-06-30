using Dapper;
using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using GestionTelefonos.Shared.Contracts.Forms;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GestionTelefonos.Data.Dapper.Repositories
{
    public class SimRepository : ISimRepository
    {
        private readonly string connectionString;

        public SimRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeleteSim(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM Sim where ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public async Task<IEnumerable<Sim>> GetSimsAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Sim";
                return await db.QueryAsync<Sim>(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task SaveSimAsync(Sim sim)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                    @"INSERT INTO
                            Sim (IDLine, Nserie, type, Number, PIN, PUK)
                            VALUES (@idline, @nserie, @type, @number, @pin, @puk)";

                await db.ExecuteAsync(query,
                    new
                    {
                        idline = sim.IDLine,
                        nserie = sim.NSerie,
                        type = sim.Type,
                        number = sim.Number,
                        pin = sim.PIN,
                        puk = sim.PUK
                    });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task UpdateSim(Sim sim)
        {
            try
            {

                using IDbConnection db = new SqlConnection(connectionString);

                string query = @"UPDATE Sim 
                     SET IDLine = @idline,Nserie = @nserie, Type = @type,Number = @number ,PIN = @pin,PUK = @puk WHERE ID = @id";
                await db.ExecuteAsync(query,
                new
                {
                    idline = sim.IDLine,
                    nserie = sim.NSerie,
                    type = sim.Type,
                    number = sim.Number,
                    pin = sim.PIN,
                    puk = sim.PUK,
                    id = sim.ID

                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task<IEnumerable<Sim>> GetSimsAsync(string tipo)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Sim WHERE type LIKE @tipo";
                return await db.QueryAsync<Sim>(query, new { tipo = $"%{tipo}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Sim>> GetSimsAsyncBuscador(SimSearcherForm simForm)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @$"
                            SELECT
                                * 
                            FROM 
                                Sim 
                            WHERE 
                                1=1
                                {(string.IsNullOrEmpty(simForm.IDLine.ToString()) ? "" : "AND IDLine = @idline")}
                                {(string.IsNullOrEmpty(simForm.NSerie)? "" : "AND NSerie LIKE @nserie")}
                                {(string.IsNullOrEmpty(simForm.Type) ? "" : "AND Type LIKE @type")}      
                                {(string.IsNullOrEmpty(simForm.Number.ToString()) ? "" : "AND Number LIKE @number")}       
                                {(string.IsNullOrEmpty(simForm.PIN) ? "" : "AND PIN LIKE @pin")}
                                {(string.IsNullOrEmpty(simForm.PUK) ? "" : "AND PUK LIKE @puk")}       
                    ";
                return await db.QueryAsync<Sim>(query, new
                {
                    idline = simForm.IDLine,
                    nserie = $"%{simForm.NSerie}%",
                    type = $"%{simForm.Type}%",
                    number=simForm.Number,
                    pin = $"%{simForm.PIN}%",
                    puk = $"%{simForm.PUK}%"
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
