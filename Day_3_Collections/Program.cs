
//List yapısı
//Listeler referans tiplidir.

//List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//numbers.Add(11);
//numbers.Add(10);
//numbers.AddRange(new int[] { 25, 26, 77, 30 });
//1. Yöntem
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//2.Yöntem
//numbers.ForEach(y=> Console.WriteLine(y));
//Console.WriteLine($"numbers dizisi içerisinde 30 var mı?: {numbers.Contains(30)}");
//Console.WriteLine($"numbers listesi içinde 30 un indeksi nedir : {numbers.IndexOf(30)}");
//Console.WriteLine($"numbers listesi kaç elemanlıdır : {numbers.Count}");

//2 tane listem olucak numbers listesi içerisindeki tek ve çift sayıları ayırıp ekrana bastırıcak.
//even numbers
//odd numbers

//List<int> evenNumbers = new List<int>();
//List<int> oddNumbers = new List<int>();

//1.yöntem
//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//        evenNumbers.Add(number);
//    else
//    {
//        oddNumbers.Add(number);
//    }

//}
//2.Yöntem
//evenNumbers = numbers.FindAll(number => number % 2 == 0);
//oddNumbers = numbers.FindAll(number => number % 2 == 1);

//3.yöntem
//evenNumbers =numbers.Where(x=>x % 2 ==0).ToList();
//oddNumbers = numbers.Where(x => x % 2 !=0).ToList();

//Console.WriteLine("Çift Sayılar:");
//evenNumbers.ForEach(x => Console.Write($"{x},  "));
//Console.WriteLine("Tek Sayılar:");
//oddNumbers.ForEach(x => Console.Write($"{x}, "));

using System.Windows.Markup;

HashSet<int>hashNumbers = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 5, 6, 5, 6, 1, 2 };
foreach( int i in hashNumbers)
{
    Console.WriteLine(i);
}

//Dictionary

Dictionary<string,int> meyveler = new Dictionary<string, int>();
meyveler.Add("Elma", 12);
meyveler.Add("Üzüm", 25);
meyveler.Add("Kiraz", 18);
meyveler.Add("Portakal", 35);

Console.WriteLine($"Elmanın fiyatı: {meyveler["Elma"]}");
meyveler["Üzüm"] = 20;
Console.WriteLine($"Üzümün fiyatı: {meyveler["Üzüm"]}");

if(meyveler.ContainsKey("Karpuz"))
{
    Console.WriteLine($"Karpuz fiyatı : {meyveler["Karpuz"]}");

}
else
{
    Console.WriteLine("Karpuz mevcut değildir. ");
}    
foreach(KeyValuePair<string,int> meyve in meyveler )
{
    Console.WriteLine($"Meyve adı : {meyve.Key}, Meyve fiyatı : {meyve.Value}");
}
meyveler.Remove("Üzüm");
foreach(var meyve in meyveler)
{
    Console.WriteLine($"Meyve adı : {meyve.Key}, Meyve fiyatı : {meyve.Value}");
}

var Keys = meyveler.Keys;
foreach (var key in Keys)
{
    Console.WriteLine(key);

}
var Values = meyveler.Values;
foreach (var value in Values)
{
Console.WriteLine(value);
}








