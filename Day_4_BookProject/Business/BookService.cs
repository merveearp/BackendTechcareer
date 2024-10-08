﻿

using Day_4_BookProject.Data;
using Day_4_BookProject.Exceptions;
using Day_4_BookProject.Models;

namespace Day_4_BookProject.Business;

//DEPENDENCY Injection (Constructor args Injection(encok kullanılan yöntem) , setter injection , method injection)
//AddScopped ,AddSingleton ,AddTransient
//Single Responsibility 
//Open Closed - değişime kapalı gelişime açık metodlar
//Liskow subs değişebilirlik kuralı 
//Interface segre.
//Dependency Inversion

public class BookService : IBookService

{
    private readonly IBookRepository _bookRepository;
    public BookService (IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    //ekleme işi yapılırken kitap başlığı minimum 2 karakterli olmalıdır.
    //price ve stok eksi değer alamaz.


    public void Add(Book book)
    {
        //    if(book.Title.Length<2  || (book.Price <0 || book.Stock < 0))
        //    {
        //        Console.WriteLine("Kurallardan geçemedi");
        //        return;
        //    }


        //validasyon kurallarını geçemeyen kitabı listeye eklemeyeceğiz.
        try
        {
            AddRules(book);
            _bookRepository.Add(book);

            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        //1.yöntem

        //catch (BookTitleException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (BookPriceAndStockException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

    }

        public void Delete(int id)
    {
        try 
        {
            _bookRepository.Delete(id);
            GetList();
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    public void GetById(int id)
    {
        try
        { 
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);
        }
        catch (BookNotFoundException ex )
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach (book => Console.WriteLine(book));
    }
    private void AddRules(Book book)
    {
        if (book.Title.Length<2 )
        {
            throw new BookTitleException(book.Title);
            
        }
        if(book.Price<0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price , book.Stock);
        }
    }
}
