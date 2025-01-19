using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hotel_app.Models
{
    public enum StatusRoom
    {
        Available,
        Occupied,
        Dirty,
        Maintenance
    }
    public class Room
    {
        
        
            [Key]
            public int Id { get; set; }
            public int Numero { get; set; }

            public string? Description { get; set; }

            public double Surface { get; set; }

            public StatusRoom Statut { get; set; }

            public int TypeChambreId { get; set; }

            [ForeignKey("TypeChambreId")]
            public TypeChambre? TypeChambre { get; set; }
        }
}


