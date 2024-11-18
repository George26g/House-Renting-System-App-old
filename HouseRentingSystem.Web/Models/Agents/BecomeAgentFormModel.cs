using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Web.Models.Agents
{
    public class BecomeAgentFormModel
    {
        [Required]
        [Phone]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "The phone number must be between 10 and 15 characters long.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}