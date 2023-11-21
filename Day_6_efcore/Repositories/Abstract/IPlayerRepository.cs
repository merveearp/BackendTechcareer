using Day_6_efcore.Models;

namespace Day_6_efcore.Repositories.Abstract;

public interface IPlayerRepository
{
    void Add(Player player);
    Player? GetById(int id);
    void Delete(int  id);
    void Update(Player player);
    List<Player> GetAll();  
}
