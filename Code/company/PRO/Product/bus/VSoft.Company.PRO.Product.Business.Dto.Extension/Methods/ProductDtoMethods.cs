﻿using VSoft.Company.PRO.Product.Business.Dto.Data;
using VSoft.Company.PRO.Product.Data.Entity.Models;

namespace VSoft.Company.PRO.Product.Business.Dto.Extension.Methods;

public static class ProductDtoMethods
{
    public static MProductEntity GetEntity(this ProductDto src, bool isForUpdate)
    {
        return new MProductEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Price = src.Price,
            Quatity = src.Quatity,
            Category = src.Category,
            Description = src.Description,
        };
    }
}
