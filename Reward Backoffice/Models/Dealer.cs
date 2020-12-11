using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.Models
{
    public class Dealer
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DealerId { get; set; } = 0;  
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Code { get; set; } = "";
        [Required]
        public string Branch { get; set; } = "";

        [DisplayName("Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; } = "";
        public string IC { get; set; } = "";

        [DisplayName("Status")]
        public bool status { get; set; } = false;

        [DisplayName("Cost Sharing")]
        [Range(0, 100, ErrorMessage = "Cost sharing must be greater than 0 and less than 100")]
        public decimal cost_sharing { get; set; } = 0;

    }
}
