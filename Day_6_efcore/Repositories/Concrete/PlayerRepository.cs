﻿using Day_6_efcore.Context;
using Day_6_efcore.Exceptions;
using Day_6_efcore.Models;
using Day_6_efcore.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Day_6_efcore.Repositories.Concrete;
public class PlayerRepository : IPlayerRepository
{
    private readonly BaseDbContext _context;

    public PlayerRepository(BaseDbContext context)
    {
        _context = context;
    }

    public void Add(Player player)
    {
        _context.Players.Add(player);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var player = _context.Players.Find(id);
        if (player is null)
        {
            throw new NotFoundException(id);
        }
        _context.Players.Remove(player);
        _context.SaveChanges();

    }

    public List<Player> GetAll()
    {
        return _context.Players.
            Include(X=>X.Team).
            Include(x=>x.Branch).
            Include(x=>x.Outfit).ToList();
           
    }
        public Player? GetById(int id)
    {
       var player = _context.Players.
            Include(X => X.Team).
            Include(x => x.Branch).
            Include(x => x.Outfit).SingleOrDefault(x=>x.Id==id);

        if (player is null)
        {
            throw new NotFoundException(id);
        } 
        return player;
    }

    public void Update(Player player)
    {
        var updatedPlayer = _context.Players.Find(player.Id);
            if (updatedPlayer is null)
            {
            throw new NotFoundException(player.Id);
            }
        _context.Players.Update(player);
        _context.SaveChanges();
    }
}
