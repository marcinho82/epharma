using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPharma.Interface;
using EPharma.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EPharma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IClient _iclient;
        public ClientController(IClient iclient)
        {
            _iclient = iclient;
        }

        // GET: api/<ClientController>
        [HttpGet]
        public List<Clients> Get()
        {
            return _iclient.GetClientsAll();
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Clients Get(int id)
        {
            return _iclient.GetUnique(id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post(Clients clients)
        {
            _iclient.InsertClient(clients);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Clients clients)
        {
            _iclient.UpdateClient(id, clients);
        }
       
    }
}
