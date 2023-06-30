using GestionTelefonos.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task<IEnumerable<Employee>> GetEmployeesAsync(string observacion);
        Task<IEnumerable<Employee>> GetEmployees2Async(string observacion);

        Task SaveEmployeeAsync(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int ID);
    }
}
