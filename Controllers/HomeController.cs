using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiAuth.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApiAuth.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Quem é você, safado? ";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => $"Aoba  - {User?.Identity?.Name}";

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee, manager")]
        public string Employee() => "Zé oreia";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Eu sou patrão não funcionaro";


    }
}
