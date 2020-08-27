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
  public class PlacesController : ControllerBase
  {
    private SaferSpacesApiContext _db;

    public PlacesController(SaferSpacesApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Place>> GetAction(string name, string type, string address)
    {
      var query = _db.Places.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type.Contains(type));
      }
      if (address != null)
      {
        query = query.Where(entry => entry.Address.Contains(address));
      }
      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Place> Get(int id)
    {
      return _db.Places.FirstOrDefault(entry => entry.PlaceId == id);
    }

    [HttpPost]
    public void Post([FromBody] Place place)
    {
      _db.Places.Add(place);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Place place)
    {
      place.PlaceId = id;
      _db.Entry(place).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var placeToDelete = _db.Places.FirstOrDefault(entry => entry.PlaceId == id);
      _db.Places.Remove(placeToDelete);
      _db.SaveChanges();
    }

    // [HttpGet("rating/best")]
    // public ActionResult<IEnumerable<Place>> GetBestRating()
    // {
    //   var query = _db.Places.OrderByDescending(entry => entry.Rating);
    //   return query.ToList();
    // }

    // [HttpGet("rating/worst")]
    // public ActionResult<IEnumerable<Place>> GetWorstRating()
    // {
    //   var query = _db.Places.OrderBy(entry => entry.Rating);
    //   return query.ToList();
    // }

    // [HttpGet("pages/")] //pagination
    // public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
    // {
    //   var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
    //   var pagedData = await _db.Places
    //     .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
    //     // Say we need to get the results for the third page of our website, counting 20 as the number of results we want. That would mean we want to skip the first ((3 – 1) * 20) = 40 results, and then take the next 20 and return them to the caller.
    //     .Take(validFilter.PageSize)
    //     .ToListAsync();
    //   var totalRecords = await _db.Places.CountAsync();
    //   return Ok(new PagedResponse<List<Place>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    // }

    // [HttpGet("{id}")] // pagination
    // public async Task<IActionResult> GetById(int id)
    // {
    //   var place = await _db.Places.Where(a => a.PlaceId == id).FirstOrDefaultAsync();
    //   return Ok(new Response<Place>(place));
    // }
  }
}


// place controller details route
// list all place attributes which includes a list of events
// click on an event

// event controller details/id route
// list that specific events details
