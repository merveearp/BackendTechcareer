

using Day_4_BookProject.Models;

namespace Day_4_BookProject.Business;

public interface IBookService
{
    void GetList();
    void Add(Book book);
    void Delete(int id);
    void GetById(int id);

}
