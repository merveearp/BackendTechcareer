
//Kitap ekleme ,listeleme ve silme gibi operasyonları simüle edeceğiz.
//veri tabanı gibi çalışan bir liste kullanacağız

using Day_4_BookProject.Business;
using Day_4_BookProject.Data;
using Day_4_BookProject.Exceptions;
using Day_4_BookProject.Models;
//Dapper

IBookService bookService = new BookService(new BookRepository());
//bookService.GetList();

Book book = new Book()
{
    Id = 5,
    Description = "TEST",
    Price =2500,
    Stock = 2000,
    Title = "Test"
};
Console.WriteLine("KAYIT EKLEME");
bookService.Add(book);
//Console.WriteLine( "KAYIT SİLME");
//bookService.Delete(2);
//Console.WriteLine("IDYE GÖRE GETİRME");
//bookService.GetById(2);
//Console.WriteLine("KİTAPLARIN LİSTESİ");
//bookService.GetList();
