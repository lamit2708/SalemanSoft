﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSoft.Company.USR.User.Business.Dto.Data
{
    public class UserDto
    {
        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Address { get; set; }

        /// <summary>
        /// True: Male, False: Female
        /// </summary>
        public bool? Gender { get; set; }

        public int? PriorityId { get; set; }

        public long? UserInfoId { get; set; }

        public bool IsBought { get; set; }

        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}