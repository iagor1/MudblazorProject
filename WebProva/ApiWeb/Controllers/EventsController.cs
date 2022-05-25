using AppCore.Data;
using AppCore.Model;
using Microsoft.AspNetCore.Mvc;


namespace ApiWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventContext _db;
        public EventsController(EventContext db)
        {
            _db = db;  
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok( _db.Events);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var events = _db.Events.Find(id);
            if (events == null)
                return NotFound();
            return Ok( events );
            
        }

        // POST api/<EventsController>
        [HttpPost]
        public IActionResult Post([FromBody] Event events)
        {
            if (events == null)
                return BadRequest();
            _db.Events.Add(events);
            _db.SaveChanges();
            return Created($"events/{events.Id}", events);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Event events)
        {
            if(id != events.Id)
                return BadRequest();
            _db.Events.Update(events);
            _db.SaveChanges();
            return NoContent();
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var eventos = _db.Events.Find(id);
            if (eventos == null)
                return NotFound();
            _db.Events.Remove(eventos);
            _db.SaveChanges();
            return NoContent();
        }
    }
}
