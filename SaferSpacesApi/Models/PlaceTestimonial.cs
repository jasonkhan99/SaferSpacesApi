namespace SaferSpacesApi.Models
{
  public class PlaceTestimonial
  {
    public int PlaceTestimonialId { get; set; }
    public int PlaceId { get; set; }
    public int TestimonialId { get; set; }
    public Place Place { get; set; }
    public Testimonial Testimonial { get; set; }
  }
}