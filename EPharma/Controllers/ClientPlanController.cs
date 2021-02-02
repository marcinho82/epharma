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
    public class ClientPlanController : ControllerBase
    {

        private readonly IClientPlan _clientPlan;

        public ClientPlanController(IClientPlan clientPlan)
        {
            _clientPlan = clientPlan;
        }
                     

        // POST api/<ClientPlanController>
        [HttpPost]
        public void Post([FromBody]ClientPlan clientPlan )
        {
            _clientPlan.Insert(clientPlan);
        }

       
    }
}
