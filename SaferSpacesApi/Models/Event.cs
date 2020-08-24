using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace SaferSpacesApi.Models
{
  public class Event
  {
    public Event()
    {
      this.Testimonials = new HashSet<Testimonial>();
    }

    public int EventId { get; }
    [Required]
    public string Name { get; set; }
    [Required]
    public DateTime EventDate { get; set; }
    [Required]
    public DateTime EventTime { get; set; }
    [Required]
    public string Description { get; set; }
    public virtual ICollection<Testimonial> Testimonials { get; set; }
  }
}