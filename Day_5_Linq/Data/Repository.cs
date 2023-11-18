using Day_5_Linq.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_5_Linq.Data;

public class Repository
{
    public static List<Product> Products { get; set; } = new List<Product>()
    {
        new Product() { Id = 1, CategoryId = 1, Name = "Msi Laptop", Price = 35000, Stock = 2000 },
        new Product() { Id = 2, CategoryId = 1, Name = "Monster Laptop", Price = 25000, Stock = 2500 },
        new Product() { Id = 3, CategoryId = 1, Name = "Apple Laptop", Price = 55000, Stock = 1000 },
        new Product() { Id = 4, CategoryId = 2, Name = "Samsung Telefon", Price = 27000, Stock = 4000 },
        new Product() { Id = 5, CategoryId = 2, Name = "Apple Telefon", Price = 44000, Stock = 1200 },
        new Product() { Id = 6, CategoryId = 2, Name = "Oppo Telefon", Price = 21000, Stock = 5500 },

    };
    public static List<Category> Categories { get; set; } = new List<Category>()
    { 
        new Category() { Id = 1,Name ="Bilgisayar"},
        new Category() { Id = 2,Name = "Telefon"}
    };
}
