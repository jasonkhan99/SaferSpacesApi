using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaferSpacesApi.Models
{
  public class Testimonial
  {
    public int TestimonialId { get; }

    public string Story { get; set; }

    public string Management { get; set; }

    public string Other { get; set; }

  }
}




