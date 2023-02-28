using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;

namespace VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;

public class CustomerInfoDbContext : EfcDbContext<CustomerInfoDbContext, MCustomerInfoEntity>
{
    public CustomerInfoDbContext(DbContextOptions<CustomerInfoDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        entity.ToTable("CustomerInfo");
    }

    protected void ConfigIndex(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.CustomerInfoInfoId, "FK_CustomerInfoInfo_TO_CustomerInfo");
        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_CustomerInfo");
        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.CustomerInfoInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
