using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;

namespace VSoft.Company.TIC.Ticket.Data.Db.Contexts;

public class TicketDbContext : EfcDbContext<TicketDbContext, MTicketEntity>
{
    public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MTicketEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MTicketEntity> entity)
    {
        entity.ToTable("Ticket");
    }

    protected void ConfigIndex(EntityTypeBuilder<MTicketEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.TicketInfoId, "FK_TicketInfo_TO_Ticket");
        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_Ticket");
        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MTicketEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.TicketInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
