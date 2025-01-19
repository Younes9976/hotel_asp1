using System.ComponentModel.DataAnnotations;

namespace hotel_app.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public string? Nom { get; set; }

        public string? Description { get; set; }

        public double Prix { get; set; }

        public string? Type { get; set; }
    }
}
