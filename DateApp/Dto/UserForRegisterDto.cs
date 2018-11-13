using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateApp.Dto
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(16, MinimumLength =4, ErrorMessage ="You must specify password between 4 and 8 chracters")]
        public string Password { get; set; }
    }

  
}
