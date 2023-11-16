using Day_4_BookProject.Exceptions;
using Day_4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Data;

public class BookRepository :IBookRepository
{
    private readonly List<Book> _bookData;

    public BookRepository()
    {
        //seed data
        _bookData = new List<Book>()
        {
            new Book { Id = 1,CategoryId="A", Description = "Güzel bir kitap", Price = 250, Stock = 2500, Title = "Sherlock Holmes" },
            new Book { Id = 2,CategoryId = "A",  Description = "Akıcı bir kitap", Price = 120, Stock = 500, Title = "Arsen Lüpen" },
            new Book { Id = 3,CategoryId = "B", Description = "Çok değerli bir kitap", Price = 300, Stock = 5000, Title = "Nutuk" },
            new Book { Id = 4,CategoryId="B", Description = "Güzel bir kitap", Price = 133, Stock = 1452, Title = "Cengiz Han ın Haytı" },
            new Book { Id = 5,CategoryId = "B",  Description = "Akıcı bir kitap", Price = 684, Stock = 544, Title = "Napolyon" },
            new Book { Id = 6,CategoryId = "B", Description = "Çok değerli bir kitap", Price = 753, Stock = 180, Title = "Sümerin Göksel Ataları" },
            new Book { Id = 7,CategoryId="C", Description = "Güzel bir kitap", Price = 250, Stock = 2500, Title = "İyi Hissetme" },
            new Book { Id = 8,CategoryId = "C",  Description = "Akıcı bir kitap", Price = 300, Stock = 50, Title = "Psikoloji" },
            new Book { Id = 9,CategoryId = "C", Description = "Çok değerli bir kitap", Price = 180, Stock = 578, Title = "Psikoloji Köşesi" }
        };
    }
    public void Add(Book book)
    {
        _bookData.Add(book);
       
    }

    public void Delete(int id)
    {
        Book? book = _bookData.Where(x=>x.Id==id).SingleOrDefault();
        if(book is null )
        {
            throw new BookNotFoundException(id);
        }
        _bookData.Remove(book);
    }

    public List<Book> GetAll()
    {
        return _bookData;
    }

    public Book? GetById(int id)
    {
        Book? book = _bookData.SingleOrDefault(x=>x . Id==id);
        if(book == null)
        {
          throw new BookNotFoundException(id);
        }
        
            return book;
        
    }
}

