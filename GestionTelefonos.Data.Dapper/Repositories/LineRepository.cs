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
    public class LineRepository : ILineRepository
    {
        private readonly string connectionString;

        public LineRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public async Task<bool> DeleteLine(int ID)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "DELETE FROM Lines where ID = " + ID.ToString();
                await db.ExecuteAsync(query).ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<Line>> GetLinesAsync()
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Lines";
                return await db.QueryAsync<Line>(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public async Task<IEnumerable<Line>> GetLinesAsync(string observacion)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query = "SELECT * FROM Lines WHERE Observations LIKE @observacion OR IDCompany LIKE @observacion ";
                return await db.QueryAsync<Line>(query, new { observacion = $"%{observacion}%" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Line>> GetLinesAsyncBuscador(LineSearcherForm lineForm)
        {
            try
            {
                //var listIds = System.Text.Json.JsonSerializer.Deserialize<List<int>>(lineForm.CompanyIds);
                using IDbConnection db = new SqlConnection(connectionString);
                string query = @$"
                            SELECT
                                *
                            FROM
                                Lines
                            WHERE
                                1=1
                                {(lineForm.CompanyIds.Count==0 ? "" : "AND IDCompany IN @companyId")}
                                {(lineForm.AdmitDateInicio == null && lineForm.AdmitDateFin == null ? "" : "AND AdmitDate BETWEEN @admitdateinicio AND @admitdatefin")} 
                                {(lineForm.DischargeDateInicio == null && lineForm.DischargeDateFin == null ? "" : "AND DischargeDate BETWEEN @dischargedateinicio AND @dischargedatefin")}
                                {(string.IsNullOrEmpty(lineForm.IDRate.ToString()) ? "" : "AND IDRate = @rate")}
                                {(string.IsNullOrEmpty(lineForm.Observations) ? "" : "AND Observations LIKE @observation")}
                                {(string.IsNullOrEmpty(lineForm.PhoneNumber.ToString()) ? "" : "AND PhoneNumber LIKE @phonenumber")}
                    ";
                
                return await db.QueryAsync<Line>(query, new
                {
                    companyId= lineForm.CompanyIds,
                    admitdateinicio= lineForm.AdmitDateInicio,
                    admitdatefin= lineForm.AdmitDateFin,
                    dischargedateinicio= lineForm.DischargeDateInicio,
                    dischargedatefin= lineForm.DischargeDateFin,
                    rate= lineForm.IDRate,
                    observation = $"%{lineForm.Observations}%",
                    phonenumber= lineForm.PhoneNumber
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
                return null;
            }
        }

        public async Task SaveLineAsync(Line line)
        {
            try
            {
                using IDbConnection db = new SqlConnection(connectionString);
                string query =
                    @"INSERT INTO
                            Lines (IDCompany, AdmitDate, DischargeDate, IDRate, Observations,PhoneNumber)
                            VALUES (@idcompany, @admitdate, @dischargedate, @idrate, @observations,@phonenumber)";

                await db.ExecuteAsync(query,
                    new
                    {
                        idcompany = line.IDCompany,
                        admitdate = line.AdmitDate,
                        dischargedate = line.DischargeDate,
                        idrate = line.IDRate,
                        observations = line.Observations,
                        phonenumber = line.PhoneNumber

                    });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task UpdateLine(Line line)
        {
            try
            {

                using IDbConnection db = new SqlConnection(connectionString);

                string query = @"UPDATE Lines 
                     SET IDCompany = @idcompany,AdmitDate = @admitdate,DischargeDate = @dischargedate,IDRate = @idrate ,Observations = @observations,PhoneNumber = @phonenumber WHERE ID = @id";
                await db.ExecuteAsync(query,
                new
                {
                    idcompany = line.IDCompany,
                    admitdate = line.AdmitDate,
                    dischargedate = line.DischargeDate,
                    idrate = line.IDRate,
                    observations = line.Observations,
                    phonenumber = line.PhoneNumber,
                    id = line.ID
                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
