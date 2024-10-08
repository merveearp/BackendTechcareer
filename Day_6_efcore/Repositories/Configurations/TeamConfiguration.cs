﻿using Day_6_efcore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day_6_efcore.Repositories.Configurations;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("Teams_db").HasKey(t => t.Id);
        builder.Property(t => t.Id).HasColumnName("team_id").IsRequired();
        builder.Property(t=>t.TeamName).HasColumnName("team_name").IsRequired();

        builder.HasMany(t => t.Players);


        builder.HasData(
        new Team() { Id=1,TeamName="Galatasaray"}
       );
    }
}
