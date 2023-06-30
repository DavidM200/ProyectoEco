using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using GestionTelefonos.Shared.Contracts.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IRateService rateService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public RateController(IRateService rateService)
        {
            this.rateService = rateService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rate>>> Get()
        {
            var rates = await rateService.GetRatesAsync();
            return Ok(rates);
        }
        [HttpGet("buscar/{nombre}")]
        public async Task<ActionResult<IEnumerable<Rate>>> Search(string nombre)
        {
            var rates = await rateService.GetRatesAsync(nombre);
            return Ok(rates);
        }
        [HttpPost("buscar")]
        public async Task<ActionResult<IEnumerable<Rate>>> SearchForm([FromBody] RateSearcherForm rateForm)
        {
            var rates = await rateService.GetRates2Async(rateForm);
            return Ok(rates);

        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Rate rate)
        {
            await rateService.SaveRateAsync(rate);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(Rate rate)
        {
            await rateService.UpdateRate(rate);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool result = await rateService.DeleteRate(id);
            if (result)
                return Ok();
            else
                return BadRequest();

        }
    }
}
