﻿namespace Day_6_efcore.Models;
public class Branch
{
    public int Id { get; set; }
    public string BranchName { get; set; }
    public List<Player> Players { get; set; }
}
