﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.ACT.Activity.Data.Entity.Models;

namespace VSoft.Company.ACT.Activity.Data.Db.Contexts;

public class ActivityDbContext : EfcDbContext<ActivityDbContext, MActivityEntity>
{
    public ActivityDbContext(DbContextOptions<ActivityDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MActivityEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MActivityEntity> entity)
    {
        entity.ToTable("Activity");
    }

    protected void ConfigIndex(EntityTypeBuilder<MActivityEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
    }


    protected void ConfigBasicFields(EntityTypeBuilder<MActivityEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512);
        entity.Property(e => e.Name).HasMaxLength(100);
    }

 

}
