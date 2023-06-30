
using GestionTelefonos.Server.Services;
using GestionTelefonos.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionTelefonos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PayMethodController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        IPayMethodService payMethodService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public PayMethodController(IPayMethodService payMethodService)
        {
            this.payMethodService = payMethodService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PayMethod>>> Get()
        {
            var paymethods = await payMethodService.GetPayMethodsAsync();
            return Ok(paymethods);
        }
        [HttpGet("buscar/{nombre}")]
        public async Task<ActionResult<IEnumerable<PayMethod>>> Search(string nombre)
        {
            var paymethods = await payMethodService.GetPayMethodsAsync(nombre);
            return Ok(paymethods);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PayMethod payMethod)
        {
            await payMethodService.SavePayMethodAsync(payMethod);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(PayMethod payMethod)
        {
            await payMethodService.UpdatePayMethod(payMethod);
            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            bool result = await payMethodService.DeletePayMethod(id);
            if (result)
                return Ok();
            else
                return BadRequest();
        }
    }
}
