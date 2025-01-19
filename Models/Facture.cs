using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_app.Models
{
    public class Facture
    {
        [Key]
        public int Numero { get; set; }

        public DateTime DateEmission { get; set; }

        public double MontantHT { get; set; }

        public double MontantTTC { get; set; }

        public double TVA { get; set; }

        public string Statut { get; set; } = string.Empty;

        [ForeignKey("SejourId")]
        public int SejourId { get; set; }
        public Sejour? Sejour { get; set; }
    }
}
