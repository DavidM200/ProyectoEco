using GestionTelefonos.Shared;
using System.Threading.Tasks;

namespace GestionTelefonos.Client.Services
{
    public interface IEmployeeService
    {

        Task<Employee[]> Buscar(string observacion);
        Task<Employee[]> BuscarForm(string name);

        Task<Employee[]> GetEmployees();

        Task InsertEmployeeAsync(Employee newEmployee);

        Task UpdateEmployeeAsync(Employee editingEmployee);

        Task<bool> DeleteEmployeeAsync(int ID);
    }
}

