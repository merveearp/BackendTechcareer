//Product adında bir classımız olsun ürünün kdvli fiyatını ekrana gösteren senaryoyu yazınız.
//Book adında bir classımız olsun Yazar adı küçük harf ile girilmiş ise ilk harfleri büyük olsun
//Kitap fiyatına kdv uygulansın.

using Day_3;
using Day_3.Managers;
//using System.Net;

//Product product = new Product();
//product.SetName("Laptop");
//product.SetPrice(250000);

//Console.WriteLine($"{product.getName()} --> KDV'Lİ FİYATI {product.GetPrice()}");

//Person person = new Person();
//person.Name = "Farah Zeynep";
//person.Surname = "Abdullah";
//person.Email ="farahzeynep@gmail.com";
//person.Password = "denemeAbc";
//Console.WriteLine(person);

//Book book = new Book()
//{
//    Author = "sait faik abasıyanık",
//    Price = 125,
//    Title = "deneme başlığı",

//};
//Console.WriteLine(book);

Car car = new Car()
{
    BrandName = "DÜLDÜL",
        Colour = Colour.Black,
        ModelYear =2005,
        Price = 350000
};
Console.WriteLine(car);
CarManager carManager = new CarManager();
carManager.Add(car);
