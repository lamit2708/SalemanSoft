﻿using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;
using VSoft.Company.DSH.DealStepHistory.Repository.UnitTest.Bases;

namespace VSoft.Company.DSH.DealStepHistory.Repository.UnitTest.Test.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MDealStepHistoryEntity Entity => new MDealStepHistoryEntity()
        {
            //Id = 63452,
           
            Name = "Đặng Thế Nhân",
         
        };
    }
}
