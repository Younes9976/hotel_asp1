using System.ComponentModel.DataAnnotations;

namespace hotel_app.Models

{
    public enum Role
    {
        Manager,
        Receptionniste,
        Perso_Menage
    }
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nom { get; set; }

        [Required, MaxLength(50)]
        public string Prenom { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telephone { get; set; }

        public string Adresse { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Role Role { get; set; }

    }
}
