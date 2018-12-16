using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WiredBrain.MultiTenant;

namespace WiredBrain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantCheckController : ControllerBase
    {
        private readonly AppTenant _appTenant;
        public TenantCheckController(AppTenant appTenant)
        {
            _appTenant = appTenant;
        }
        // GET: api/TenantCheck
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _appTenant.Name };
        }

        // GET: api/TenantCheck/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TenantCheck
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TenantCheck/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
