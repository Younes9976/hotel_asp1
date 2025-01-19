using System.ComponentModel.DataAnnotations;

namespace hotel_app.Models
{
    
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string? Nom { get; set; }

        [Required, MaxLength(50)]
        public string? Prenom { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? Telephone { get; set; }

        public string? Adresse { get; set; }

        public string? Nationalite { get; set; }

        public string? PieceIdentite { get; set; } 

        public string? NumeroPieceIdentite { get; set; }

        public List<Reservation>? Reservations { get; set; }
    }
}
