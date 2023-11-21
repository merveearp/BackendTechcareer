using Day_6_efcore.Models;

namespace Day_6_efcore.Dtos.Responses;
public class OutfitDto
{
    public int Id { get; set; }
    public OutfitType Type { get; set; }
    public short No { get; set; }
    public string BrandName { get; set; }
}
