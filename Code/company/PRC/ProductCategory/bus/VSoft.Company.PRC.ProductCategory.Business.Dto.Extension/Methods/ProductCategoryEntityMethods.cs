﻿using VSoft.Company.PRC.ProductCategory.Business.Dto.Data;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;

namespace VSoft.Company.PRC.ProductCategory.Business.entity.Extension.Methods;

public static class ProductCategoryEntityMethods
{
    public static ProductCategoryDto GetDto(this MProductCategoryEntity src)
    {
        return new ProductCategoryDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            ProductCategoryInfoId = src.ProductCategoryInfoId,
            IsBought = src.IsBought,
        };
    }
}
