using PropertyAdvertiser.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyAdvertiser.Web.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(DataConstants.NameMaxLength)]
        [MinLength(DataConstants.NameMinLength)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
