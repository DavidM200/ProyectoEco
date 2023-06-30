using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesEmployeeController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ILinesEmployeeService linesEmployeeService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LinesEmployeeController(ILinesEmployeeService linesEmployeeService)
        {
            this.linesEmployeeService = linesEmployeeService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LinesEmployee>>> Get()
        {
            var lin = await linesEmployeeService.GetLinesEmployeeAsync();
            return Ok(lin);
        }
        [HttpGet("buscar /{consulta}")]
        public async Task<ActionResult<IEnumerable<LinesEmployee>>> Search(string consulta)
        {
            var lin = await linesEmployeeService.GetLinesEmployeeAsync(consulta);
            return Ok(lin);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] LinesEmployee linesEmployee)
        {
            await linesEmployeeService.SaveLinesEmployee(linesEmployee);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(LinesEmployee linesEmployee)
        {
            await linesEmployeeService.UpdateLinesEmployee(linesEmployee);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await linesEmployeeService.DeleteLinesEmployee(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }
    }
}
