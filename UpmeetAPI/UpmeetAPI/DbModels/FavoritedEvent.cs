using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpmeetAPI.DbModels
{
    public class FavoritedEvent
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? EventId { get; set; }

        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }
    }
}
