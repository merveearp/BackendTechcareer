namespace Day_6_efcore.Dtos.Reuqests;

public class CreatePlayerRequestDto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string BranchName { get; set; }
    public string TeamName { get; set; }
    public decimal Price { get; set; }

}
