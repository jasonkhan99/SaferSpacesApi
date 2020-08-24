using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SaferSpacesApi.Models
{
  public class Place
  {
    public Place()
    {
      this.Events = new HashSet<Event>();
      this.Testimonials = new HashSet<Testimonial>();
    }
    public int PlaceId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public string Address { get; set; }
    public string Description { get; set; }
    [DisplayName("Restroom Details")]
    public Restroom RestroomFeatures { get; set; }
    public virtual ICollection<Event> Events { get; set; }
    public virtual ICollection<Testimonial> Testimonials { get; set; }
  }

  public enum Restroom
  {
    Accessible,
    GenderNeutral,
    Both,
    None
  }
}