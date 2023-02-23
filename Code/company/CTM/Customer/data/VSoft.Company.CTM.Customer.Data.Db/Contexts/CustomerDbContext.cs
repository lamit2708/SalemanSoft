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
    
        ConfigBasicFields(builder);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MCustomerEntity> builder)
    {
        builder.ToTable("Customer");
    }

    protected void ConfigIndex(EntityTypeBuilder<MCustomerEntity> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");
        builder.HasIndex(e => e.CustomerInfoId, "FK_CustomerInfo_TO_Customer");

        builder.HasIndex(e => e.PriorityId, "FK_Priority_TO_Customer");

        builder.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MCustomerEntity> builder)
    {
        builder.Property(e => e.Id).HasColumnType("bigint(20)");
        builder.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        builder.Property(e => e.CustomerInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        builder.Property(e => e.Email).HasMaxLength(100);
        builder.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.Phone).HasMaxLength(100);
        builder.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
