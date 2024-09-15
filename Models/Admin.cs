using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public required string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public required string LastName { get; set; }
        [Display(Name = "Email Address")]
        public decimal Quote { get; set; }
    }
}
