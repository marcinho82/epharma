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
    public class PlanController : ControllerBase
    {
        private readonly IPlan _iplan;
        public PlanController(IPlan iplan)
        {
            _iplan = iplan;
        }

        // GET: api/<PlanController>
        [HttpGet]
        public List<Plans> Get()
        {
            return _iplan.GetPlansAll();
        }

        // GET api/<PlanController>/5
        [HttpGet("{id}")]
        public Plans Get(int id)
        {
            return _iplan.GetUnique(id);
        }

        // POST api/<PlanController>
        [HttpPost]
        public void Post([FromBody] Plans plans)
        {
            _iplan.InsertPlan(plans);
        }

        // PUT api/<PlanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Plans plans)
        {
            _iplan.UpdatePlan(id,plans);
        }       
    }
}
