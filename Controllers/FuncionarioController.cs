using FuncionariosAPI.Business;
using FuncionariosAPI.Business.Implementations;
using FuncionariosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly ILogger<FuncionarioController> _logger;
        private IFuncionarioBusiness _business;

        public FuncionarioController(ILogger<FuncionarioController> logger, IFuncionarioBusiness business)
        {
            _logger = logger;
            _business = business;
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var result = _business.FindById(id);

            if (result is null) return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_business.FindAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Funcionario funcionario)
        {
            if (funcionario is null) return NotFound();

            return Ok(_business.Create(funcionario));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Funcionario funcionario)
        {
            if (funcionario is null) return NotFound();

            return Ok(_business.Update(funcionario));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _business.Delete(id);

            return NoContent();
        }
    }
}
