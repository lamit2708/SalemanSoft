﻿using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.ORD.Order.Data.Entity.Models
{
    public class MOrderEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public long CustomerId { get; set; }

        public int UserId { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
