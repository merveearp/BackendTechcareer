﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Inheritance.Managers;
public class CategoryService : ICrudService
{
    public void Add()
    {
        Console.WriteLine("Kategori eklendi.");
    }

    public void Delete()
    {
        Console.WriteLine("Kategori silindi."); 
    }

    public void GetAll()
    {
        Console.WriteLine("Kategori listelendi.");
    }

    public void Update()
    {
        Console.WriteLine("Kategori güncellendi.");
    }
}
