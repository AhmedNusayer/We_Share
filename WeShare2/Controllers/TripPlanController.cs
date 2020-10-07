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
    public class TripPlanController : ControllerBase
    {


        private readonly WeShareDbContext _context;

        public TripPlanController(WeShareDbContext context)
        {
            _context = context;
        }

        // GET: api/TripPlan
        [HttpGet]
        public ActionResult<IEnumerable<TripPlan>> GetTripPlan()
        {
            return _context.TripPlans.ToList();
        }

        // Get: api/TripPlan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TripPlan>> GetTripPlan(int id)
        {
            var tripPlan = await _context.TripPlans.FindAsync(id);

            if (tripPlan == null)
            {
                return NotFound();
            }

            return tripPlan;
        }

        // POST: api/TripPlan
        [HttpPost]
        public async Task<ActionResult<TripPlan>> PostTripPlan(TripPlan item)
        {
            _context.TripPlans.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTripPlan), new { id = item.Id }, item);
        }



    }
}