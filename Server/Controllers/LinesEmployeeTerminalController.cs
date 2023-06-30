using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesEmployeeTerminalController : ControllerBase
    {
        ILinesEmployeeTerminalService linesEmployeeTerminalService;
        public LinesEmployeeTerminalController(ILinesEmployeeTerminalService linesEmployeeTerminalService)
        {
            this.linesEmployeeTerminalService = linesEmployeeTerminalService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LinesEmployeeTerminal>>> Get()
        {
            var lin = await linesEmployeeTerminalService.GetLinesEmployeesTerminalsAsync();
            return Ok(lin);
        }
        [HttpGet("buscar/{consulta}")]
        public async Task<ActionResult<IEnumerable<LinesEmployeeTerminal>>> Search(string consulta)
        {
            var lin = await linesEmployeeTerminalService.GetLinesEmployeesTerminalsAsync(consulta);
            return Ok(lin);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] LinesEmployeeTerminal linesEmployeeTerminal)
        {
            await linesEmployeeTerminalService.SaveLinesEmployeeTerminal(linesEmployeeTerminal);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(LinesEmployeeTerminal linesEmployeeTerminal)
        {
            await linesEmployeeTerminalService.UpdateLinesEmployeeTerminal(linesEmployeeTerminal);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await linesEmployeeTerminalService.DeleteLinesEmployeeTerminal(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }
    }
}
