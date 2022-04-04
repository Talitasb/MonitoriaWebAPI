using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonitoriaWebAPI.Data;
using System;

namespace MonitoriaWebAPI.Controllers
{
    [ApiController]
    [Route("Clientes")]
    public class ClienteController : ControllerBase
    {
        private AplicationContext context;

        [HttpGet]
        public List<Cliente> ListarClientes()
        {
            context = new AplicationContext();
            List<Cliente> clientes = context.Clientes.ToList();
            return clientes;
        }
}
}
