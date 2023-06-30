using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Services
{
    public class LinesEmployeeService : ILinesEmployeeService
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ILinesEmployeeRepository linesEmployeeRepository;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LinesEmployeeService(ILinesEmployeeRepository linesEmployeeRepository)
        {
            this.linesEmployeeRepository = linesEmployeeRepository;
        }
        public async Task<bool> DeleteLinesEmployee(int ID)
        {
            return await linesEmployeeRepository.DeleteLinesEmployeeAsync(ID);
        }

        public async Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync()
        {
            return await linesEmployeeRepository.GetLinesEmployeeAsync();
        }

        public async Task<IEnumerable<LinesEmployee>> GetLinesEmployeeAsync(string consulta)
        {
            return await linesEmployeeRepository.GetLinesEmployeeAsync(consulta);
        }

        public async Task SaveLinesEmployee(LinesEmployee linesEmployee)
        {
            await linesEmployeeRepository.SaveLinesEmployeeAsync(linesEmployee);
        }

        public async Task UpdateLinesEmployee(LinesEmployee linesEmployee)
        {
            await linesEmployeeRepository.UpdateLinesEmployee(linesEmployee);
        }
    }
}
