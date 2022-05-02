using System.ComponentModel.DataAnnotations;

namespace AppCore.Model
{
    public class Event
    {
        public int? Id { get; set; }
        [StringLength(255)]
        [Required]
        public string? Name { get; set; }
        [StringLength(4000)]
        public string? Description { get; set; }
        [StringLength(150)]
        public string? Situation { get; set; }

        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }

    }
}
