using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_app.Models
{
    public class Sejour
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateArrivee { get; set; }

        public DateTime DateDepart { get; set; }

        public double MontantTotal { get; set; }

        public int ReservationId { get; set; }
        [ForeignKey("ReservationId")]
        public required Reservation Reservation { get; set; }

        public ICollection<LigneService>? LigneServices { get; set; }

        public Facture Facture { get; set; } = new Facture();
    }
}
