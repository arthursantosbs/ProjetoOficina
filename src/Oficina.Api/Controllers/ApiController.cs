using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oficina.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {

        [HttpGet]
        public IActionResult Home()
        {
            Object obj = new
            {
                nome = "Marcelo"
            };
            return Ok(obj);
        }
    }
}