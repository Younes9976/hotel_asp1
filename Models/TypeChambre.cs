using System.ComponentModel.DataAnnotations;

namespace hotel_app.Models
{
    public class TypeChambre
    {
        [Key]
        public int Id { get; set; }

        public string? Nom { get; set; }

        public string? Description { get; set; }

        public double TarifBase { get; set; }

        public int Capacite { get; set; }

        public List<Room>? Rooms { get; set; }
    }
}
