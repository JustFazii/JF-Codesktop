﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codesktop.Models.AccountViewModels
{
    public class LoginWithRecoveryCodeViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Recovery Code")]
        public string RecoveryCode { get; set; }
    }
}
