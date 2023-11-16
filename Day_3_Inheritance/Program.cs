

//Product ve Category 2 Tane veritabanı tablomuzun olduğunu düşünelim bu tablolar arasında basit crut operasyonlarını yapınız.
//Create - Read - Update - Delete 
using Day_3_Inheritance;
using Day_3_Inheritance.Managers;
using System;
//Interfaceler anlaşmadır.
//Interfaceler soyut classlardır new anahtar sözcüğü ile nesnesi yürütülemez.

//Category category = new Category()

//{
//    Id =1,
//    CategoryName = "Bilgisayar",
//    CreatedBy ="Merve Türk",
//    CreateDate= "2023"
//};
//Product product= new Product()
//{
//    Id = 1,
//    CreatedBy = "Merve Türk",
//    CreateDate = "2023",
//    Name = "Msi",
//    Price = 1200
//};
//Console.WriteLine(category);
//Console.WriteLine(product);

ICrudService crudservice = new CategoryService();
crudservice.Add();
crudservice.Delete();
crudservice.GetAll();
crudservice.Update();



