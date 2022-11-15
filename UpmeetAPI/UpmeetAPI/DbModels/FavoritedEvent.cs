using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpmeetAPI.DbModels
{
    public class FavoritedEvent
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public string UserId { get; set; }
    }
}
