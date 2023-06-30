using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneIncidenceController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IPhoneIncidenceService phoneIncidenceService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public PhoneIncidenceController(IPhoneIncidenceService phoneIncidenceService)
        {
            this.phoneIncidenceService = phoneIncidenceService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhoneIncidence>>> Get()
        {
            var incidence = await phoneIncidenceService.GetIncidentsAsync();
            return Ok(incidence);
        }
        [HttpGet("buscar/{descripcion}")]
        public async Task<ActionResult<IEnumerable<PhoneIncidence>>> Search(string descripcion)
        {
            var incidences = await phoneIncidenceService.GetIncidentsAsync(descripcion);
            return Ok(incidences);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PhoneIncidence phoneIncidence)
        {
            await phoneIncidenceService.SaveIncidenceAsync(phoneIncidence);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(PhoneIncidence phoneIncidence)
        {
            await phoneIncidenceService.UpdateIncidence(phoneIncidence);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool result = await phoneIncidenceService.DeleteIncidence(id);
            if (result)
                return Ok();
            else
                return BadRequest();
        }
    }
}
