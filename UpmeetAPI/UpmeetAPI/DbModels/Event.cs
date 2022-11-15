using System.ComponentModel.DataAnnotations;

namespace UpmeetAPI.DbModels
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Performing { get; set; }
        public string ImgUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Venue { get; set; }
        public decimal Price { get; set; }
        public bool Favorite { get; set; }
        public string EventDateTime { get; set; }
        public string EventCategory { get; set; }
        public string ContactInfo { get; set; }
        public string Description { get; set; }
    }
}
