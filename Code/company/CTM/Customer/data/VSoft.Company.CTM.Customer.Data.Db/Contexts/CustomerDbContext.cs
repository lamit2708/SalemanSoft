using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Data.Db.Contexts;

public class CustomerDbContext : EfcDbContext<CustomerDbContext, MCustomerEntity>
{
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MCustomerEntity> builder)
    {
        ConfigTable(builder);

        ConfigIndex(builder);
        ConfigBaseFields(builder);      
        ConfigBasicFields(builder);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MCustomerEntity> builder)
    {
        builder.ToTable("Customer");
    }

    protected void ConfigIndex(EntityTypeBuilder<MCustomerEntity> builder)
    {
        builder.HasKey(e => e.Id).HasName("pk_Customer");
      
        builder.HasIndex(e => e.FullName, "IDX_Customer_FullName");
    }

    protected void ConfigBaseFields(EntityTypeBuilder<MCustomerEntity> builder)
    {
       
        builder.Property(e => e.IsDeleted).HasColumnName("IsDeleted");
    }

    protected void ConfigBasicFields(EntityTypeBuilder<MCustomerEntity> builder)
    {
        builder.Property(e => e.Id).HasColumnName("Id").HasMaxLength(128);       
        builder.Property(e => e.FullName).HasColumnName("FullName").HasMaxLength(100);

        builder.Property(e => e.UpdatedDate).HasColumnType("datetime").HasColumnName("UpdatedDate");
        builder.Property(e => e.CreatedDate).HasColumnType("datetime").HasColumnName("CreatedDate");
    }

 

}
