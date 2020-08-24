using Microsoft.EntityFrameworkCore;

namespace SaferSpacesApi.Models
{
  public class SaferSpacesApiContext : DbContext
  {
    public SaferSpacesApiContext(DbContextOptions<SaferSpacesApiContext> options)
        : base(options)
    {
    }

    public DbSet<Place> Places { get; set; }

    public DbSet<Event> Events { get; set; }

    public DbSet<Testimonial> Testimonials { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>()
        .HasData(
          new Place { PlaceId = 1, Name = "White Owl Social Club", Type = "Bar", Address = "1305 SE 8th Ave, Portland, OR 97214", Description = "A bar with DJ's and Live Music and an outdoor patio.", Restroom = true, Events = new HashSet<Event>() { }, Tes timonials = new HashSet<Testimonial>() { } }

          new Place { PlaceId = 2, Name = "Bit House Saloon", Type = "Bar", Address = "727 SE Grand Ave, Portland, OR 97214", Description = "A bar with a dance floor upstairs nightky events.", Restroom = false, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } }

          new Place { PlaceId = 3, Name = "No Fun", Type = "Bar", Address = "1709 SE Hawthorne Blvd, Portland, OR, 97214", Description = "A bar with live music and events.", Restroom = true, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } }

          new Place { PlaceId = 4, Name = "No Fun", Type = "Bar", Address = "1709 SE Hawthorne Blvd, Portland, OR, 97214", Description = "A bar with live music and events.", Restroom = true, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } }
  }