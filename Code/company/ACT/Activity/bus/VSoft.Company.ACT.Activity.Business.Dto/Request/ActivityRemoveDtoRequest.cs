﻿using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.ACT.Activity.Business.Dto.Request
{
    public class ActivityRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? ACTName { get; set; }
       
    }
}
