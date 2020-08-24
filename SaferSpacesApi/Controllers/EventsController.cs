using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaferSpacesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace SaferSpacesApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EventsController : ControllerBase
  {
    private SaferSpacesApiContext _db;

    public EventsController(SaferSpacesApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Event>> GetAction()
    {
      return _db.Events.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Event event)
    {
      _db.Events.Add(event);
    _db.SaveChanges();
    }

  [HttpPut("{id}")]
  public void Put(int id, [FromBody] Event event)
  {
    event.EventId = id;
    _db.Entry(event).State = EntityState.Modified;
    _db.SaveChanges();
  }

  [HttpDelete("{id}")]
  public void Delete(int id)
  {
    var eventToDelete = _db.Events.FirstOrDefault(entry => entry.EventId == id);
    _db.Events.Remove(eventToDelete);
    _db.SaveChanges();
  }
}
}
