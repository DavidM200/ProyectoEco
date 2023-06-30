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
    public class CompanyController : ControllerBase
    {
#pragma warning disable IDE0044 // Agregar modificador de solo lectura
        ICompanyService companyService;
#pragma warning restore IDE0044 // Agregar modificador de solo lectura

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> Get()
        {
            var companies = await companyService.GetCompaniesAsync();
            return Ok(companies);
        }
        [HttpGet("buscar/{nombre}")]
        public async Task<ActionResult<IEnumerable<Company>>> Search(string nombre)
        {
            var companies = await companyService.GetCompaniesAsync(nombre);
            return Ok(companies);
        }

        //Revisar para hacer los formularios con posibilidad de dejar campos vacios

        [HttpPost("buscar")]
        public async Task<ActionResult<IEnumerable<Company>>> SearchForm([FromBody]CompanySearcherForm companyForm)
        {
            var companies = await companyService.GetCompanies2Async(companyForm);
            return Ok(companies);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Company company)
        {
            await companyService.SaveCompanyAsync(company);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(Company company)
        {
            await companyService.UpdateCompany(company);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Obtener resultado
            bool result = await companyService.DeleteCompany(id);

            // Comprobaciones

            // Retornar código según resultado
            if (result)
                return Ok(); // Añadir parametros si es necesario
            else
                return BadRequest();
        }
    }
}
