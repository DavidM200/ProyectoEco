using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface ILinesEmployeeRepository
    {
        Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync();
        Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync(string consulta);
        Task SaveLinesEmployeeAsync(LinesEmployee linesEmployee);
        Task UpdateLinesEmployee(LinesEmployee linesEmployee);
        Task<bool> DeleteLinesEmployeeAsync(int ID);
    }
}
