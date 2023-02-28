using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.CIN.CustomerInfo.Data.Entity.Models
{
    public class MCustomerInfoEntityBasic : IIdEntity<long>
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

        public long? CustomerInfoInfoId { get; set; }

        public bool IsBought { get; set; }
    }
}
