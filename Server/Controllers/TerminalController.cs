using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared.Contracts.Forms;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ITerminalService terminalService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public TerminalController(ITerminalService terminalService)
        {
            this.terminalService = terminalService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Terminal>>> Get()
        {
            var terminals = await terminalService.GetTerminalsAsync();
            return Ok(terminals);
        }
        [HttpGet("buscar/{observacion}")]
        public async Task<ActionResult<IEnumerable<Terminal>>> Search(string observacion)
        {
            var terminals = await terminalService.GetTerminalsAsync(observacion);
            return Ok(terminals);
        }
        [HttpPost("buscar")]
        public async Task<ActionResult<IEnumerable<Terminal>>> SearchForm([FromBody]TerminalSearcherForm terminalForm)
        {
            var terminals = await terminalService.GetTerminals2Async(terminalForm);
            return Ok(terminals);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Terminal terminal)
        {
            await terminalService.SaveTerminalAsync(terminal);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Terminal terminal)
        {
            await terminalService.UpdateTerminal(terminal);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await terminalService.DeleteTerminal(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }

    }
}
