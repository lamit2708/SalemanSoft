using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;

namespace VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;

public class CustomerSourceDbContext : EfcDbContext<CustomerSourceDbContext, MCustomerSourceEntity>
{
    public CustomerSourceDbContext(DbContextOptions<CustomerSourceDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        entity.ToTable("CustomerSource");
    }

    protected void ConfigIndex(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.CustomerSourceInfoId, "FK_CustomerSourceInfo_TO_CustomerSource");
        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_CustomerSource");
        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.CustomerSourceInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
