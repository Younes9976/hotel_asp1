using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hotel_app.Models
{
    public enum StatutReservation
    {
        Confirmed,
        Pending,
        Canceled
    }
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_Check_in { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_Check_out { get; set; }

        public StatutReservation Statut { get; set; }

        public double MontantTotal { get; set; }

        [ForeignKey("ChambreId")]
        public int RoomId { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }

        public Room? Room { get; set; }

        public Sejour? Sejour { get; set; }
    }
}
