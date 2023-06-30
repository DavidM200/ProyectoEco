using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IEmployeeService employeeService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            var employees = await employeeService.GetEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet("buscar/{nombre}")]
        public async Task<ActionResult<IEnumerable<Employee>>> Search(string nombre)
        {
            var employees = await employeeService.GetEmployeesAsync(nombre);
            return Ok(employees);
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Employee employee)
        {
            await employeeService.SaveEmployeeAsync(employee);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Employee employee)
        {
            await employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool result = await employeeService.DeleteEmployee(id);
            if (result)
                return Ok();
            else
                return BadRequest();
        }
    }
}