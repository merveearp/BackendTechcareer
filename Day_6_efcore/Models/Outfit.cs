namespace Day_6_efcore.Models;
public class Outfit
{
    public int Id { get; set; }
    public OutfitType Type { get; set; }
    public short No { get; set; }
    public string BrandName { get; set; }

    public int PlayerId { get; set; }
    public Player Player { get; set; }
}
public enum OutfitType
{
   Winter,
   Summery
}
