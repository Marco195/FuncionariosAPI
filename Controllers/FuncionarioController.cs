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

        public FuncionarioController(ILogger<FuncionarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {

        }

        [HttpPost]
        public IActionResult Post([FromBody] Funcionario funcionario)
        {

        }

        [HttpPut]
        public IActionResult Update([FromBody] Funcionario funcionario)
        {

        }

    }
}
