using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class EmployeeService : IEmployeeService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IEmployeeRepository employeeRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<bool> DeleteEmployee(int ID)
        {
            return await employeeRepository.DeleteEmployee(ID);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await employeeRepository.GetEmployeesAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(string observacion)
        {
            return await employeeRepository.GetEmployeesAsync(observacion);
        }
        public async Task<IEnumerable<Employee>> GetEmployees2Async(string observacion)
        {
            return await employeeRepository.GetEmployeesAsyncBuscador(observacion);
        }

        public async Task SaveEmployeeAsync(Employee employee)
        {
            await employeeRepository.SaveEmployeeAsync(employee);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await employeeRepository.UpdateEmployee(employee);
        }
    }
}