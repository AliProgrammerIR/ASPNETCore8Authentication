using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GoalLearn101.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "نام")]
        [MaxLength(150 , ErrorMessage = "طول فیلد {0} برای بر با {1} می باشد")]
        public String? FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [MaxLength(150, ErrorMessage = "طول فیلد {0} برای بر با {1} می باشد")]
        public String? LastName { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public DateTimeOffset RegistrationDateOffset { get; set; }
    }
}
