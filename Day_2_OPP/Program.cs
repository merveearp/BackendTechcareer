//Person adında bir class oluşturulur ve gerekli işlemler yapılır.
//Oluşturulan nesnelerin ekrana bastırılması
//classlar bizim için bir referans tipidir.
//referanslar oluşturulurken tipler oluşturulurken new anahtar sözcüğü ile oluşturulur.
using Day_2_OPP;
using System.ComponentModel;
//1.Yöntem
Person person = new();
person.name = "Merve";
person.age = 27;
person.surname = "Arpacıoğlu";
person.phone = "0123456789";
//Console.WriteLine(person);
Console.WriteLine(person);

//2.Yöntem

Person person1 = new Person();
person1.name = "İ";
person1.surname = "TÜRK";
person1.age = 15;
person1.phone = "";
//IsNullOrEmpty "" çalışır, IsNullOrWhiteSpace mesela "    " kullanılır.

Person.Add(person1);

//3.Yöntem
var person2 = new Person(25, "Mine", "Arpacıoğlu", "15623579");
person2.name = "Zeynep";
Console.WriteLine(person2);

KayıtOl kayıtOl = new(username: "deneme", password: "deneme");
kayıtOl.Success();
KayıtOl kayıtOl1 = new(username: "Merveearp", password: "deneme", city:"Ordu",state:"Karadeniz" );
kayıtOl1.Success();
//record -> immutable data classlardır
//struct ->Yapı olarak karşımıza gelir

Product product = new Product(Name: "deneme", Description: "KÖTÜ", Price: 15.51);


Person person3 = new Person()
{
    name = "asdasd",
    age = 27,
    phone ="123456",
    surname = "SDFSDJFHJ",

};
person3.name = "ayşe";
Console.WriteLine(person3);
Console.WriteLine(product);
//record ve class referans tiplidir.
//struct ise değer tiplidir.

Book book;
book.Adı = "Abasıyanık";
book.Yazar = "Sait Faik";
book.SayfaSayısı = 125;
Console.WriteLine(book);
//*****************STRUCT*************
//Structlar değer tipindedir
//Bellekte ek hafızada tutulur
//new anahtar sözcüğü kullanmadan oluşturulabilir.
//Büyük veri setleri için değil,küçük veri setleri için uygundur.

//*****************RECORD***************
//.Net5 ve C# 9.0 İLE TANITILDI.
//Temel amacı veriyi saklamak genellikle adına da veri taşıyıcıları denir.
//Değişmezlik immutable classlardır.




//structlar bir classtan miras alamazlar ,sadece interfaceden miras alabilirler.