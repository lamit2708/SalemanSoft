﻿using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;
using VSoft.Company.PRC.ProductCategory.Repository.UnitTest.Bases;
using VSoft.Company.PRC.ProductCategory.Repository.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.PRC.ProductCategory.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestProductCategoryReal : TestMgmtEntities
{
    protected override string TestName { get; set; } = "Real";

    [TestMethod]
    [DataRow(5, DisplayName = "GetByIdAsync > 1")]
    [DataRow(6, DisplayName = "GetByIdAsync > 2")]
    public async Task GetByIdAsync(int id)
    {
        await TestGetByIdAsync(id);
    }

    [TestMethod]
    [DataRow("Phần mềm")]
    [DataRow("Dự án web")]
    [DataRow("Dự án mobile")]
    public async Task CreateAsync(string name)
    {
        var e = new A01().GetCreateEntity();
        e.Name = name;


        await TestCreateAsync(e);
    }

    //[TestMethod]
    //// [DataRow("Đặng Thế Nhân1", "35049843957", "aaa@gmail.com")]
    //// [DataRow("Lê Vũ Lâm1", "02345332565", "abc@yahoo.com")]
    //[DataRow("Nguyễn Tấn Phát2", "5434634858", "xyz133@gmail.com")]
    //public async Task CreateWithKeywordAsync(string fullName, string phone, string email)
    //{
    //    var e = new A01().GetCreateEntity();
    //    e.Name = fullName;
    //    e.Phone = phone;
    //    e.Email = email;

    //    await RunTest("CreateWithKeywordAsync", async (r, l) =>
    //    {
    //        var res = r?.CreateWithKeyword(e);
    //        LogEntity(res, l);
    //    });
    //}

    [TestMethod]
    [DataRow(1, "Thiết kế phần mềm")] // 
    [DataRow(2, "Thiết kế website")]
    [DataRow(3, "Thiết kế ứng dụng mobile")]
    [DataRow(4, "Xây dựng hệ thống quản lý")] 
    //[DataRow(5, "Xây dựng hệ thống quản lý phòng trọ")] //Xây dựng hệ thống quản lý
    //[DataRow(5, "Xây dựng hệ thống quản lý trung tâm ngoại ngữ")] //Xây dựng hệ thống quản lý
    //[DataRow(5, "Xây dựng hệ thống quản lý quán cà phê")] //Xây dựng hệ thống quản lý
    //[DataRow(5, "Xây dựng hệ thống quản lý nhà hàng")] //Xây dựng hệ thống quản lý
    //[DataRow(5, "Nâng cấp hệ thống CRM")] //Nâng cấp hệ thống
    //[DataRow(5, "Nâng cấp hệ thống ERP")] //Nâng cấp hệ thống
    //[DataRow(5, "Nâng cấp hệ thống bán hàng")] //Nâng cấp hệ thống
    //[DataRow(5, "Nâng cấp hệ thống mobile")] //Nâng cấp hệ thống
    //[DataRow(1, "Website bán quần áo")] // Thiết kế ứng dụng bán hàng
    //[DataRow(1, "Website cửa hàng điện tử")] // Thiết ứng dụng bán hàng
    //[DataRow(1, "Thiết kế ứng dụng bán hàng theo yêu cầu")] // Thiết ứng dụng bán hàng
    public async Task UpdateAsync(int id, string name)
    {
        await TestUpdateAsync(new MProductCategoryEntity()
        {
            Id = id,
            Name = name,
           
        });
    }
    //[TestMethod]
    //[DataRow(1, "Dự án phần mềm 1")]
    //[DataRow(2, "Dự án web blazor 1")]
    //[DataRow(3, "Dự án mobile 1")]
    //public async Task UpdateWithKeywordAsync(int id, string name)
    //{
    //    var newEntity = new MProductCategoryEntity()
    //    {
    //        Id = id,
    //        Name = name,
           
    //    };
    //    await RunTest("TestUpdateProductCategory", async (r, l) =>
    //    {
    //        // var dbEntity = await (r?.GetByIdAsync(newEntity.Id) ?? Task.FromResult<MProductCategoryEntity?>(null));

    //        var e = r?.UpdateWithKeyword(newEntity);
    //        LogEntity(e, l);
    //        return;

    //        l($"Id: {newEntity?.Id} update false!");
    //    });
    //}

    [TestMethod]
    [DataRow(6)]
    public async Task DeleteAsync(int id)
    {

        await TestDeleteAsync(id);
    }

    [TestMethod]
    [DataRow("web")]
    [DataRow("du an")]
    public async Task GetProductCategoryByNameAsync(string name)
    {

        await RunTest("GetProductCategoryByNameAsync", async (r, log) =>
        {
            var e = await (r?.GetProductCategorysByNameAsync(name) ?? Task.FromResult(new List<MProductCategoryEntity>()));
            e.ForEach(x => log(x.Name));
            //log(e.FirstOrDefault()?.Name ?? string.Empty);
        });
    }
}