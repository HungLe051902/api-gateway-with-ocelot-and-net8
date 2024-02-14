using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadBalancerTestController : ControllerBase
    {
        // GET: api/<LoadBalancerTestController>
        [HttpGet]
        public string Get()
        {
            return "LoadBalancerTest in Order API";
        }

        // GET api/<LoadBalancerTestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoadBalancerTestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoadBalancerTestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoadBalancerTestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
