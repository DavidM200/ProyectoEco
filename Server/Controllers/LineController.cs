using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ILineService lineService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public LineController(ILineService lineService)
        {
            this.lineService = lineService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Line>>> Get()
        {
            var lines = await lineService.GetLinesAsync();
            return Ok(lines);
        }


        [HttpGet("buscar/{observacion}")]
        public async Task<ActionResult<IEnumerable<Line>>> Search(string observacion)
        {
            var lines = await lineService.GetLinesAsync(observacion);
            return Ok(lines);
        }
        [HttpPost("buscar")]
        public async Task<ActionResult<IEnumerable<Line>>> SearchForm([FromBody] LineSearcherForm lineForm)
        {
            var lines = await lineService.GetLines2Async(lineForm);
            return Ok(lines);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Line line)
        {
            await lineService.SaveLineAsync(line);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(Line line)
        {
            await lineService.UpdateLine(line);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await lineService.DeleteLine(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }
    }
}
