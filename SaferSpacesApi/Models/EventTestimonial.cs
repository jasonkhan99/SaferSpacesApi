namespace SaferSpacesApi.Models
{
  public class EventTestimonial
  {
    public int EventTestimonialId { get; set; }
    public int TestimonialId { get; set; }
    public int EventId { get; set; }
    public Testimonial Testimonial { get; set; }
    public Event Event { get; set; }
  }
}