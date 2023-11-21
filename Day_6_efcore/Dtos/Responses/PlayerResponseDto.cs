using Day_6_efcore.Models;

namespace Day_6_efcore.Dtos.Responses;

public class PlayerResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public TeamDto Team { get; set; }
    public OutfitDto Outfit { get; set; }
    public BranchDto Branch { get; set; }
    public decimal Price { get; set; }

}
