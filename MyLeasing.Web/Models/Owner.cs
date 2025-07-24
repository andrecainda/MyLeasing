using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Document")]
        public string Document { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(100)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Owner Name")]
        public string OwnerName => $"{FirstName} {LastName}";
    }
}
