using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

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
          new Place { PlaceId = 1, Name = "White Owl Social Club", Type = "Bar", Address = "1305 SE 8th Ave, Portland, OR 97214", Description = "A bar with DJ's and Live Music and an outdoor patio.", RestroomFeatures = (Restroom)1, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } },

          new Place { PlaceId = 2, Name = "Bit House Saloon", Type = "Bar", Address = "727 SE Grand Ave, Portland, OR 97214", Description = "A bar with a dance floor upstairs nightky events.", RestroomFeatures = (Restroom)3, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } },

          new Place { PlaceId = 3, Name = "No Fun", Type = "Bar", Address = "1709 SE Hawthorne Blvd, Portland, OR, 97214", Description = "A bar with live music and events.", RestroomFeatures = (Restroom)2, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } },

          new Place { PlaceId = 4, Name = "Watershed", Type = "Event Space", Address = "5040 SE Milwaukie Ave, Portland, OR, 97202", Description = "A large warehouse to throw all kinds of events", RestroomFeatures = (Restroom)1, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } },

          new Place { PlaceId = 5, Name = "Crystal Ballroom", Type = "Concert Venue", Address = "1332 W Burnside, Portland, OR, 97209", Description = "Historic Building with a stage for live music", RestroomFeatures = (Restroom)1, Events = new HashSet<Event>() { }, Testimonials = new HashSet<Testimonial>() { } }
        );

      builder.Entity<Event>()
        .HasData(
          new Event { EventId = 1, Name = "Judy on Duty", EventDate = new DateTime(2020, 9, 12, 20, 0, 0), EventTime = new DateTime(2020, 9, 12, 20, 0, 0), Description = "A queer dance party focused on building community through nightlife", },

          new Event { EventId = 2, Name = "Cosmic Cafe", EventDate = new DateTime(2020, 9, 19, 22, 0, 0), EventTime = new DateTime(2020, 9, 12, 20, 0, 0), Description = "An outer space themed karaoke dance night" },

          new Event { EventId = 3, Name = "Live in the Depths", EventDate = new DateTime(2020, 9, 26, 20, 0, 0), EventTime = new DateTime(2020, 9, 12, 20, 0, 0), Description = "A monthly live music event" }
        );

      builder.Entity<Testimonial>()
        .HasData(
          new Testimonial { TestimonialId = 1, Story = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", Management = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate", Other = "velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." }
        );
    }
  }
}