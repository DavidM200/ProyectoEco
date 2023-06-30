using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestionTelefonos.Shared.Contracts.Forms;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ISimService simService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public SimController(ISimService simService)
        {
            this.simService = simService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sim>>> Get()
        {
            var sim = await simService.GetSimsAsync();
            return Ok(sim);
        }
        [HttpGet("buscar/{tipo}")]
        public async Task<ActionResult<IEnumerable<Sim>>> Search(string tipo)
        {
            var sim = await simService.GetSimsAsync(tipo);
            return Ok(sim);
        }
        [HttpPost("buscar")]
        public async Task<ActionResult<IEnumerable<Sim>>> SearchForm([FromBody] SimSearcherForm simForm)
        {
            var sim = await simService.GetSims2Async(simForm);
            return Ok(sim);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Sim sim)
        {
            await simService.SaveSimAsync(sim);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(Sim sim)
        {
            await simService.UpdateSim(sim);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await simService.DeleteSim(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }

    }
}
