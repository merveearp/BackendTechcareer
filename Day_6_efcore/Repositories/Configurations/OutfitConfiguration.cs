using Day_6_efcore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day_6_efcore.Repositories.Configurations
{ 
public class OutfitConfiguration : IEntityTypeConfiguration<Outfit>
{
    public void Configure(EntityTypeBuilder<Outfit> builder)
    {
        builder.ToTable("Outfits_db").HasKey(o=>o.Id);
        builder.Property(o => o.Id).HasColumnName("outfit_id");
        builder.Property(o => o.BrandName).HasColumnName("outfit_brand_name");
        builder.Property(o => o.Type).HasColumnName("outfit_type");
        builder.Property(o => o.PlayerId).HasColumnName("player_id");
        builder.Property(o => o.No).HasColumnName("outfit_no");


            builder.HasOne(o => o.Player);
                builder.HasData(new Outfit() { Id=1,BrandName="Adidas",No=42,PlayerId=1,Type=OutfitType.Winter});
        }
 
 }
}