using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/Coords")]
    public class CoordsController : Controller
    {
        // GET: api/Coords
        [HttpGet]
        public IEnumerable<GraphCoord> GetCoords()
        {
            GraphCoord temp1 = new GraphCoord(111, 44.55, 55.66);
            GraphCoord temp2 = new GraphCoord(222, 66.77, 88.77);
            return new GraphCoord[] {temp1, temp2};
        }

        // GET: api/Coords/5
        [HttpGet("{id}", Name = "GetCoords")]
        public string GetCoords(int id)
        {
            return "value";
        }
        
        // POST: api/Coords
        [HttpPost]
        public void PostCoords([FromBody]string value)
        {
        }
        
        // PUT: api/Coords/5
        [HttpPut("{id}")]
        public void PutCoords(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteCoords(int id)
        {
        }
    }
}
