using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Data.Db.Contexts;

public class DealActivityDbContext : EfcDbContext<DealActivityDbContext, MDealActivityEntity>
{
    public DealActivityDbContext(DbContextOptions<DealActivityDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        entity.ToTable("DealActivity");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.DealActivityInfoId, "FK_DealActivityInfo_TO_DealActivity");
        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_DealActivity");
        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.DealActivityInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
