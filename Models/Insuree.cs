using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public required string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public required string LastName { get; set; }
        [Display(Name = "Email Address")]
        public required string EmailAddress { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Year")]
        public int CarYear { get; set; }
        [Display(Name = "Make")]
        public string CarMake { get; set; }
        [Display(Name = "Model")]
        public string CarModel { get; set; }

        public bool DUI { get; set; }
        [Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }
        [Display(Name = "Type of Coverage")]
        public bool CoverageType { get; set; }

        public decimal Quote {  get; set; }
    }
}
