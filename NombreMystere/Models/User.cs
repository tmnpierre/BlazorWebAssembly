using System.ComponentModel.DataAnnotations;

namespace NombreMystere.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Prénom manquant")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Le prénom doit être compris entre 3 et 30 caractères.")]
        [RegularExpression(@"^[a-zA-ZàâäéèêëïîôöùûüÿçÀÂÄÉÈÊËÏÎÔÖÙÛÜŸÇ'\- ]+$", ErrorMessage = "Le prénom contient des caractères non valides.")]
        public string? FirstName { get; set; }

        [Display(Name = "Nom de famille")]
        [Required(ErrorMessage = "Nom manquant")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Le nom doit être compris entre 3 et 30 caractères.")]
        [RegularExpression(@"^[a-zA-ZàâäéèêëïîôöùûüÿçÀÂÄÉÈÊËÏÎÔÖÙÛÜŸÇ'\- ]+$", ErrorMessage = "Le nom contient des caractères non valides.")]
        public string? LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email manquant")]
        [EmailAddress(ErrorMessage = "Email invalide")]
        public string? Email { get; set; }

        [Display(Name = "Adresse postale")]
        [Required(ErrorMessage = "Adresse postale manquante")]
        public string? Address { get; set; }

        [Display(Name = "Code Postal")]
        [Required(ErrorMessage = "Code postal manquant")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir 5 chiffres")]
        public int? Zip { get; set; }

        [Display(Name = "Âge")]
        [Required(ErrorMessage = "Âge manquant")]
        [Range(1, 120, ErrorMessage = "L'âge doit être compris entre 1 et 120")]
        public int? Age { get; set; }

        [Display(Name = "Date de naissance")]
        [Required(ErrorMessage = "Date de naissance manquante")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Marié(e)")]
        public bool IsMarried { get; set; }

        [Display(Name = "Couleur favorite")]
        [Required(ErrorMessage = "La couleur favorite est requise.")]
        public FavColor? FavoriteColor { get; set; }
    }

    public enum FavColor { Rouge, Vert, Bleu, Jaune, Violet, Orange }
}