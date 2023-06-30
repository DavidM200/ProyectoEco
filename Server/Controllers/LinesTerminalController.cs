using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesTerminalController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ILinesTerminalService linesTerminalService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public LinesTerminalController(ILinesTerminalService linesTerminalService)
        {
            this.linesTerminalService = linesTerminalService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LinesTerminal>>> Get()
        {
            var linT = await linesTerminalService.GetLinesTerminalAsync();
            return Ok(linT);
        }
        [HttpGet("buscar/{consulta}")]
        public async Task<ActionResult<IEnumerable<LinesTerminal>>> Search(string consulta)
        {
            var linT = await linesTerminalService.GetLinesTerminalAsync(consulta);
            return Ok(linT);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] LinesTerminal linesTerminal)
        {
            await linesTerminalService.SaveLinesTerminal(linesTerminal);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(LinesTerminal linesTerminal)
        {
            await linesTerminalService.UpdateLinesTerminal(linesTerminal);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await linesTerminalService.DeleteLinesTerminal(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }
    }
}
