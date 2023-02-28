﻿using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;

namespace VSoft.Company.CSO.CustomerSource.Repository.UnitTest.Bases
{
    public abstract class TestEntity
    {
        public virtual MCustomerSourceEntity GetCreateEntity()
        {
            var e = Entity;

            return e;
        }

        public virtual MCustomerSourceEntity GetCreateEntity(string fullName)
        {
            var e = Entity;
            e.Name = fullName;
            return e;
        }

        public virtual MCustomerSourceEntity GetUpdateEntity(int id)
        {
            var e = Entity;
            e.Id = id;
            return e;
        }

        public virtual MCustomerSourceEntity GetUpdateEntityFromData(string data)
        {
            var e = Entity;
            var arr = data.Split(" / ");
            e.Id = Convert.ToInt32(arr[0]);
            e.Name = arr[1];
            return e;
        }

        public virtual MCustomerSourceEntity GetUpdateEntity(int id, string fullName)
        {
            var e = Entity;
            e.Id = id;
            e.Name = fullName;
            return e;
        }

        protected abstract MCustomerSourceEntity Entity { get; }
    }
}
