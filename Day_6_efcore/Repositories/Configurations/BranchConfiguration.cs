using Day_6_efcore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day_6_efcore.Repositories.Configurations;

public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.ToTable("Branch_db").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("branch_id");
        builder.Property(b => b.BranchName).HasColumnName("branch_name");

        builder.HasMany(b => b.Players);

        builder.HasData(
new Branch() { Id=1,BranchName="Football"}

            );
    }
}
