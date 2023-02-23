using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Business.UnitTest.Bases;

namespace VSoft.Company.CTM.Customer.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override CustomerDto Dto => new CustomerDto()
        {
         
            FullName = "Đặng Thế Nhân",
          
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
        };
    }
}
