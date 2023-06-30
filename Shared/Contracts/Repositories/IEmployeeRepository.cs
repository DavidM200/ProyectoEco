using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Shared.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task<IEnumerable<Employee>> GetEmployeesAsync(string observacion);

        Task<IEnumerable<Employee>> GetEmployeesAsyncBuscador(string observacion);

        Task SaveEmployeeAsync(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int ID);
    }
}
