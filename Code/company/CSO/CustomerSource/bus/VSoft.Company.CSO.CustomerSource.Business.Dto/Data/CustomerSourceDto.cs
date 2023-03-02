﻿namespace VSoft.Company.CSO.CustomerSource.Business.Dto.Data
{
    public class CustomerSourceDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}
