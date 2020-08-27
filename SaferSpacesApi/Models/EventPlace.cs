namespace SaferSpacesApi.Models
{
  public class EventPlace
  {
    public int EventPlaceId { get; set; }
    public int PlaceId { get; set; }
    public int EventId { get; set; }
    public Place Place { get; set; }
    public Event Event { get; set; }
  }
}