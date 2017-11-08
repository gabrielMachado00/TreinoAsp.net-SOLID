using ProjetoCrm.Domain.Entities;
using ProjetoCrm.Infra.Data.IServiceBase;
using ProjetoCrm.Infra.Data.ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ClienteController : ApiController
    {

        private readonly IClienteService _clienteService;


        public ClienteController(IClienteService clienteService)
        {

            _clienteService = clienteService;

        }
        // GET: api/Cliente
        public IEnumerable<Cliente> Get()
        {
            return _clienteService.GetAll();   
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cliente
        public IHttpActionResult Post([FromBody]Cliente cliente)
        {

            if (!ModelState.IsValid) {

                return BadRequest(ModelState);
            }

            _clienteService.Add(cliente);

            return Ok();
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
