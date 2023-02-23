using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSoft.Company.CTM.Customer.Business.Dto.Data
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string? FullName { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public override string ToString()
        {
            return $"{Id} / {FullName}";
        }
    }
}
