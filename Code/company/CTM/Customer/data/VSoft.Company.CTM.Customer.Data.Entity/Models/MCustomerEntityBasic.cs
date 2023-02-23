using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.CTM.Customer.Data.Entity.Models
{
    public class MCustomerEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string? FullName { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
