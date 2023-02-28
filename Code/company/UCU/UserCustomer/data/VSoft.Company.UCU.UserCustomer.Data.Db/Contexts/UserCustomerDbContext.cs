using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;

public class UserCustomerDbContext : EfcDbContext<UserCustomerDbContext, MUserCustomerEntity>
{
    public UserCustomerDbContext(DbContextOptions<UserCustomerDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        entity.ToTable("UserCustomer");
    }

    protected void ConfigIndex(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.UserCustomerInfoId, "FK_UserCustomerInfo_TO_UserCustomer");
        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_UserCustomer");
        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.UserCustomerInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
