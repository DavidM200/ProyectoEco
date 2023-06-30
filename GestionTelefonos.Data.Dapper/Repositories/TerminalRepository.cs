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
    public class TerminalRepository : ITerminalRepository
    {
        private readonly string connectionString;

        public TerminalRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }

        public async Task<bool> DeleteTerminal(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM Terminals WHERE ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<Terminal>> GetTerminalsAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Terminals ORDER BY Name";
                return await db.QueryAsync<Terminal>(query).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Terminal>> GetTerminalsAsync(string nombre)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Terminals WHERE Name LIKE @nombre";
                return await db.QueryAsync<Terminal>(query, new { nombre = $"%{nombre}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Terminal>> GetTerminalsAsyncBuscador(TerminalSearcherForm terminalForm)
        {
            try
            {
                
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @$"
                             SELECT 
                                  * 
                             FROM 
                                Terminals 
                             WHERE 
                                1=1
                                {(string.IsNullOrEmpty(terminalForm.Name) ? "" : "AND Name LIKE @name")}
                                {(string.IsNullOrEmpty(terminalForm.Imei) ? "" : "AND Imei LIKE @imei")}
                                {(terminalForm.BuyDateInicio == null && terminalForm.BuyDateFin == null ? "" : "AND BuyDate BETWEEN @buydateinicio AND @buydatefin")}
                                {(string.IsNullOrEmpty(terminalForm.IdPayMethod.ToString()) ? "" : "AND IdPayMethod = @paymethod")}
                                {(string.IsNullOrEmpty(terminalForm.IdTerminalState.ToString()) ? "" : "AND IdTerminalState = @terminalstate")}
                                {(string.IsNullOrEmpty(terminalForm.Observations) ? "" : "AND Observations LIKE @observations")}
                                {(terminalForm.Paid == null ?  "" : "AND Paid LIKE @paid")}
                                {(terminalForm.FeeAmount == null ? "" : "AND FeeAmount = @feeamount")}
                                {(terminalForm.NumberOfFees == null ? "" : "AND NumberOfFees = @numberoffees")}
                                {(terminalForm.TotalAmount == null ? "" : "AND TotalAmount = @totalamount")}
                            ";
                return await db.QueryAsync<Terminal>(query, new
                {
                    name = $"%{terminalForm.Name}%",
                    imei = $"%{terminalForm.Imei}%",
                    buydateinicio= terminalForm.BuyDateInicio,
                    buydatefin= terminalForm.BuyDateFin,
                    paymethod= terminalForm.IdPayMethod,
                    paid= terminalForm.Paid,
                    terminalstate= terminalForm.IdTerminalState,
                    observations = $"%{terminalForm.Observations}%",
                    feeamount = terminalForm.FeeAmount.ToString().Replace(",", "."),
                    numberoffees= terminalForm.NumberOfFees,
                    totalamount = terminalForm.TotalAmount.ToString().Replace(",", "."),
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task SaveTerminalAsync(Terminal terminal)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                @"INSERT INTO Terminals(Name,Imei,BuyDate,IdPayMethod,Paid,IdTerminalState,Observations,FeeAmount,NumberOfFees,TotalAmount) VALUES (@name,@imei,@buydate,@idpaymethod,@paid,
                    @idterminalstate,@observations,@feeamount,@numberoffees,@totalamount)";
                await db.ExecuteAsync(query, new
                {
                    name = terminal.Name,
                    imei = terminal.Imei,
                    buydate = terminal.BuyDate,
                    idpaymethod = terminal.IdPayMethod,
                    paid = terminal.Paid,
                    idterminalstate = terminal.IdTerminalState,
                    observations = terminal.Observations,
                    feeamount = terminal.FeeAmount.ToString().Replace(",", "."),
                    numberoffees = terminal.NumberOfFees,
                    totalamount = terminal.TotalAmount.ToString().Replace(",", ".")
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdateTerminal(Terminal terminal)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @"UPDATE Terminals SET Name =@name,Imei=@imei,BuyDate=@buydate,
                    IdPayMethod=@idpaymethod,Paid = @paid, IdTerminalState =@idterminalstate, Observations=@observations,FeeAmount=@feeamount,
                    NumberOfFees=@numberoffees,TotalAmount =@totalamount WHERE ID =@id";
                await db.ExecuteAsync(query, new
                {
                    name = terminal.Name,
                    imei = terminal.Imei,
                    buydate = terminal.BuyDate,
                    idpaymethod = terminal.IdPayMethod,
                    paid = terminal.Paid,
                    idterminalstate = terminal.IdTerminalState,
                    observations = terminal.Observations,
                    feeamount = terminal.FeeAmount,
                    numberoffees = terminal.NumberOfFees,
                    totalamount = terminal.TotalAmount,
                    id = terminal.ID
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

