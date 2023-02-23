using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.UnitTest.Bases;
using VSoft.Company.CTM.Customer.Repository.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.CTM.Customer.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestCustomerReal : TestMgmtEntities
{
    protected override string TestName { get; set; } = "Real";

    [TestMethod]
    [DataRow(1, DisplayName = "GetByIdAsync > 1")]
    [DataRow(2, DisplayName = "GetByIdAsync > 2")]
    public async Task GetByIdAsync(int id)
    {
        await TestGetByIdAsync(id);
    }

    [TestMethod]
    [DataRow("Đặng Thế Nhân")]
    [DataRow("Lê Vũ Lâm")]
    [DataRow("Nguyễn Tấn Phát")]
    public async Task CreateAsync(string fullName)
    {
        var e = new A01().GetCreateEntity();
        e.FullName = fullName;
        await TestCreateAsync(e);
    }

    [TestMethod]
    public async Task UpdateAsync()
    {
        await TestUpdateAsync(new MCustomerEntity()
        {

        });
    }


    [TestMethod]
    public async Task DeleteAsync()
    {
        var id = 63452;
        await TestDeleteAsync(id);
    }
}