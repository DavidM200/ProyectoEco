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
    public class LinesTerminalRepository : ILinesTerminalRepository
    {
        private readonly string connectionString;

        public LinesTerminalRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeleteLinesTerminalAsync(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM LinesTerminal where ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM LinesTerminal";
                return await db.QueryAsync<LinesTerminal>(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        // ---  Hacer consultas separadas apara evitar fallos   ---
        public async Task<IEnumerable<LinesTerminal>> GetLinesTerminalAsync(string consulta)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM LinesTerminal WHERE IDLine LIKE @consulta OR IDTerminal LIKE @consulta";
                return await db.QueryAsync<LinesTerminal>(query, new { consulta = $"%{consulta}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task SaveLinesTerminalAsync(LinesTerminal linesTerminal)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                    @"INSERT INTO
                            LinesTerminal (IDLine, IDTerminal, StartDate, FinishDate)
                            VALUES (@idline, @idterminal, @startdate, @finishdate)";

                await db.ExecuteAsync(query,
                    new
                    {
                        idline = linesTerminal.IDLine,
                        idterminal = linesTerminal.IDTerminal,
                        startdate = linesTerminal.StartDate,
                        finishdate = linesTerminal.FinishDate

                    });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdateLinesTerminal(LinesTerminal linesTerminal)
        {
            try
            {

                using IDbConnection db = new SqlConnection(connectionString);

                string query = @"UPDATE LinesTerminal 
                     SET IDLine = @idline,IDTerminal = @idterminal, StartDate = @startdate,FinishDate = @finishdate WHERE ID = @id";
                await db.ExecuteAsync(query,
                new
                {
                    idline = linesTerminal.IDLine,
                    idterminal = linesTerminal.IDTerminal,
                    startdate = linesTerminal.StartDate,
                    finishdate = linesTerminal.FinishDate,
                    id = linesTerminal.ID

                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
