using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.UnitTest.Bases;

namespace VSoft.Company.CTM.Customer.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal: TestCustomerMgmt
    {
        [TestMethod]
        [DataRow(63491)]
        [DataRow(63492)]
        [DataRow(63493)]
        public async Task FindAsync(int id)
        {
            await TestFindAsync(new MDtoRequestFindByInt()
            {
                Id = id,
            });
        }

        [TestMethod]
        [DataRow(63494, 63495, 63496)]
        public async Task FindRangeAsync(int id1, int id2, int id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByInts()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }

        [TestMethod]
        public async Task TestCreate()
        {            
            await TestCreateAsync(new CustomerInsertDtoRequest()
            {
                Data = new CustomerDto()
                {
                    //CTMname = "it.nhan7285",
                    //Password = "Welcome@7",
                    //FullName = "Đặng Thế Nhân",
                }
            });
        }

        [TestMethod]
        public async Task TestUpdate()
        {
            await TestUpdateAsync(new CustomerUpdateDtoRequest()
            {
                Data = new CustomerDto()
                {
                    //CTMname = "it.nhan7285",
                    //Password = "Welcome@7",
                    //FullName = "Đặng Thế Nhân 1",
                }
            });
        }

        [TestMethod]
        [DataRow(63470)]
        [DataRow(63471)]
        [DataRow(63472)]
        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new CustomerDeleteDtoRequest()
            {
               // Id = "it.nhan7285",
            });
        }
    }
}