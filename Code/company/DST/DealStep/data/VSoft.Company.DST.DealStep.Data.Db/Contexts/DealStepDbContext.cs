using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DST.DealStep.Data.Entity.Models;

namespace VSoft.Company.DST.DealStep.Data.Db.Contexts;

public class DealStepDbContext : EfcDbContext<DealStepDbContext, MDealStepEntity>
{
    public DealStepDbContext(DbContextOptions<DealStepDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealStepEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealStepEntity> entity)
    {
        entity.ToTable("DealStep");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealStepEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.DealStepInfoId, "FK_DealStepInfo_TO_DealStep");
        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_DealStep");
        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MDealStepEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.DealStepInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
