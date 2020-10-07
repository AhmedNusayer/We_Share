using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeShare2.DbModels;

namespace WeShare2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripRequestController : ControllerBase
    {
        private readonly WeShareDbContext _context;
        
        public TripRequestController(WeShareDbContext context)
        {
            _context = context;
        }

        // GET: api/TripRequest
        [HttpGet]
        public ActionResult<IEnumerable<TripRequest>> GetTripRequest()
        {
            return  _context.TripRequests.ToList();
        }

        // Get: api/TripRequest/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TripRequest>> GetTripRequest(int id)
        {
            var tripRequest = await _context.TripRequests.FindAsync(id);

            if (tripRequest == null)
            {
                return NotFound();
            }

            return tripRequest;
        }

        // POST: api/TripRequest
        [HttpPost]
        public async Task<ActionResult<TripRequest>> PostTriprequest(TripRequest item)
        {
            var updatedEntry = _context.TripRequests.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTripRequest), updatedEntry);
        }


       
    }
}
