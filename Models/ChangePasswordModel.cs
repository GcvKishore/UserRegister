﻿using System.ComponentModel.DataAnnotations;

namespace UserRegister.Models
{
    public class ChangePasswordModel
    {
        [Required]
         
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required]

        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]

        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set;}

    }
}
