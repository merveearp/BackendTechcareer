
////senaryo Ürünler kategori listeleri üzerine çeşitli örnekler yapacağız.

using Day_5_Linq.Data;
using Day_5_Linq.Models;
using System.Globalization;
using System.Threading.Channels;

var products = Repository.Products;
var categories = Repository.Categories;

////Tüm ürünlerden kategori ıd si 1 olan ürünleri listeleyin.
////1.yöntem

////foreach (var product in products)
////    {
////    if(product.CategoryId == 1 )
////    {
////        Console.WriteLine(product);
////    }
////}

////2.yöntem
//Console.WriteLine("Category Id 1 olan ürünler : ");
//products.Where(p => p.CategoryId ==1).ToList().ForEach(p =>Console.WriteLine(p));

////Tüm ürünler içerisinde App geçen ürünleri listeleyin .

//Console.WriteLine("İçerisinde App geçen ürünlerin listesi : ");
////1.yöntem
////foreach (var p in products)
////{
////    if(p.Name.Contains("App"))
////    {
////        Console.WriteLine(p);
////    }

////2.Yöntem
////var PList = from p in products  where p.Name.Contains("App") select p;
////foreach (var p in PList)
////{
////    Console.WriteLine(p);
////}

////3.yöntem
//products.Where(p => p.Name.Contains("App")).ToList().ForEach(p => Console.WriteLine(p));

////Ürünlerin fiyatlarının toplamı olan kodu yazınız.


////1.yöntem

////double total = 0;
////foreach(var p in products)
////{
////    total += p.Price;

////}
////Console.WriteLine("Tüm ürünlerin toplamı = "+ total);
////2.yöntem
//var total = products.Sum(x => x.Price);
//Console.WriteLine("Tüm ürünlerin toplamı = " + total);

////Todo category ıd si 2 olan ürünlerin Price toplamlarını bulunuz.

//var total1 = products.Where(p=>p.CategoryId==2).Sum(Y => Y.Price);
//Console.WriteLine($"Category ıd si 2 olan ürünlerin Price toplamları : {total1}");

////TODO Tüm ürünlerin fiat ortalamasını alan kodu yazınız.

//var average = products.Average(z => z.Price);
//Console.WriteLine($"Tüm ürünlerin fiyat ortalaması : {average}");

////TODO : Category ıd si 3 olan var mı 

//var productIsPresent = products.Any(a => a.CategoryId == 4);
//Console.WriteLine($"Category ıd si 3 olan ürün var mı : {productIsPresent}" );

////TODO : Ürünün id si 1 olan ürünün değerlerini ekrana basınız.
//var product = products.SingleOrDefault(b => b.Id == 1);
//Console.WriteLine($"Ürünün id si 1 olan ürünün değerlerini yazdırın :  { product}");
////TODO tüm ürünlerin sadece isimlerini ekrana bastırınız. 
//products.Select(x => x.Name).ToList().ForEach(p => Console.WriteLine(p));

////TODO :Tüm ürünlerin isim stok ve price değerlerini ekrana bastıran kodu yazınız.
////1.yöntem 
////var list =products.Select (x => new {isim =x.Name,stok =x.Stock, price =x.Price}).ToList();
////foreach(var item in list)
////{ry
////    Console.WriteLine($"İsim :{item.isim},stok = {item.stok},price ={item.price}");
////}
////2.yöntem
//var list =from p in products select new {isim=p.Name ,stok = p.Stock,  price=p.Price, };
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

////TODO : CategoryID lerine göre ürünleri gruplandıralım .
//var grouppedProduct = products.GroupBy(d => d.CategoryId).ToDictionary(g => g.Key, g => g.ToList());
//foreach (var group in grouppedProduct)
//{
//    Console.WriteLine($"{group.Key} Category Id sine sahip ürünler ");
//    group.Value.ForEach(d => Console.WriteLine(d));
//}

//// Tüm ürünlerin fiyatlarını artacak şekilde sıralayınız. 

//products.OrderBy(f => f.Price).ToList().ForEach(e => Console.WriteLine(e));

////TODO : Tüm ürünlerin fiyatları azalıcak şekilde sıralayınız.
//products.OrderByDescending(g => g.Price).ToList().ForEach(f => Console.WriteLine(f));

//1.geleneksel yöntem
//var details = from p in products
//              join c in categories on p.CategoryId equals c.Id select new ProductDetailDto

//              {
//                  CategoryName = c.Name,
//                  Price = p.Price,
//                  ProductId = p.Id,
//                  ProductName = p.Name,
//                  Stock = p.Stock
//              };
//foreach  (var item in details)
//{
//    Console.WriteLine(item);
//}

//2.yöntem
//var lambdaJoin = products.Join(categories,
//    p => p.CategoryId,
//    c => c.Id,
//    (product, category) => new ProductDetailDto
//    {
//        CategoryName = category.Name,
//        Price = product.Price,
//        ProductId = product.Id,
//        ProductName = product.Name,
//        Stock = product.Stock,

//    }).ToList();
//lambdaJoin.ForEach(p => Console.WriteLine(p));

//todo : Öyle bir sistem dizayn edin ki ProductDetail listesini dönsün ama category Id si 2 olan ürünlerin detay listesi olsun.

//var filterLambdaJoin = products
//    .Where(x=>x.CategoryId==2 )
//    .Join(categories,
//    p=>p.CategoryId,
//    c=>c.Id,
//    (p,c) => new ProductDetailDto
//    {
//        CategoryName = c.Name,
//        Price = p.Price,
//        ProductId = p.Id,
//        ProductName = p.Name,
//        Stock = p.Stock,
//    }).ToList();
//filterLambdaJoin.ForEach(x=> Console.WriteLine(x));

//2.yöntem
//var lambdaJoin = products.Join(categories,
//    p => p.CategoryId,
//    c => c.Id,
//    (product, category) => new ProductDetailDto
//    {
//        CategoryName = category.Name,
//        Price = product.Price,
//        ProductId = product.Id,
//        ProductName = product.Name,
//        Stock = product.Stock,

//    }).ToList();
//lambdaJoin.FindAll(x => x.CategoryName == "Telefon").ForEach(p => Console.WriteLine(p));

List<int> numbers1 = new List<int>() { 1,2,3,4,5 };
List<int> numbers2 = new() { 4, 5, 6, 7, 8 };
List<int> numbers3 = new() { 1, 1, 2, 2, 3, 3, 10, 4, 5, 5, 10, 0, 0 };

//TODO :2 sayı listesinde ortak sayıları tek liste halinde listeleyelim.
//numbers1.Intersect(numbers2).ToList().ForEach(X=>Console.WriteLine(X));

//TODO :1. Sayı listesinde bulunan ama 2. sayı listesinde bulunmayan sayıların listesini ekrana yazdırıan kodu yazınız.
//numbers1.Except(numbers2).ToList().ForEach(x =>Console.WriteLine(x));

//TODO :1. Sayı listesinde bulunan ama 2. sayı listesinde bulunmayan sayıların üatüne ekleyip kodu yazınız.
//numbers1.Except(numbers2).ToList().ForEach(x => numbers2.Add(x));
//numbers2.ForEach(x=> Console.WriteLine(x));

//TODO : 1.Sayı listesinde bulunan sayıların çarpımını yazınız.
//Console.WriteLine(numbers1.Aggregate((a, b) => a * b));

//TODO : 3.Sayı listesinde unit değerleri(tekrar edenleri) tekrarlamadan tutan sayı listesi 
//numbers3.Distinct().ToList().ForEach(x => Console.WriteLine(x));

//TODO : 3 Sayı listesini tek liste hale getirmek için :
//numbers1.Concat(numbers2).Concat(numbers3).ToList().ForEach(x=> Console.Write($"{x}, "));

//TODO : Sayı 2 listesindek en büyük ve en kücük değeri ekrana yazınız.
//Console.WriteLine($"En küçük sayı değeri : {numbers2.Min()}, En büyük sayı değeri : {numbers2.Max()}");

//TODO : Sayı 2 listesinde 2 den büyük 3 tane sayı alan yeni listeyi yazdırın.
//numbers2.Where(x=>x> 2).Take(3).ToList().ForEach(x => Console.WriteLine(x));

