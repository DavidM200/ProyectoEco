using GestionTelefonos.Shared;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface ILinesEmployeeService
    {
        Task<LinesEmployee[]> Buscar(string consulta);
        Task<LinesEmployee[]> GetLinesEmployee();
        Task InsertLinesEmployeesAsync(LinesEmployee newLinesEmployee);
        Task UpdateLinesEmployeesAsync(LinesEmployee editingLinesEmployee);
        Task<bool> DeleteLinesEmployeesAsync(int ID);
    }
}
