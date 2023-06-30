using GestionTelefonos.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface ILinesEmployeeService
    {
        Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync();
        Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync(string consulta);
        Task SaveLinesEmployee(LinesEmployee linesEmployee);
        Task UpdateLinesEmployee(LinesEmployee linesEmployee);
        Task<bool> DeleteLinesEmployee(int ID);

    }
}
