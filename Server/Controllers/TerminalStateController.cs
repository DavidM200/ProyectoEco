using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalStateController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ITerminalStateService terminalStateService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura
        public TerminalStateController(ITerminalStateService terminalStateService)
        {
            this.terminalStateService = terminalStateService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TerminalState>>> Get()
        {
            var terminalState = await terminalStateService.GetTerminalStateAsync();
            return Ok(terminalState);
        }
        [HttpGet("buscar/{nombre}")]
        public async Task<ActionResult<IEnumerable<TerminalState>>> Search(string nombre)
        {
            var terminalState = await terminalStateService.GetTerminalStateAsync(nombre);
            return Ok(terminalState);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TerminalState terminalState)
        {
            await terminalStateService.SaveTerminalStateAsync(terminalState);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(TerminalState terminalState)
        {
            await terminalStateService.UpdateTerminalState(terminalState);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await terminalStateService.DeleteTerminalState(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }
    }
}
