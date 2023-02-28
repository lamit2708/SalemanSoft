using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;

public class DealStepHistoryDbContext : EfcDbContext<DealStepHistoryDbContext, MDealStepHistoryEntity>
{
    public DealStepHistoryDbContext(DbContextOptions<DealStepHistoryDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        entity.ToTable("DealStepHistory");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.DealStepHistoryInfoId, "FK_DealStepHistoryInfo_TO_DealStepHistory");
        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_DealStepHistory");
        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.DealStepHistoryInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
