using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_app.Models
{
    public class LigneService
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateUtilisation { get; set; }

        public int Quantite { get; set; }

        public double PrixUnitaire { get; set; }

        [ForeignKey("SejourId")]
        public int SejourId { get; set; }
        public Sejour? Sejour { get; set; }

        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
