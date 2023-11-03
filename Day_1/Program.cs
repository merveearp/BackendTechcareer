
//Console.WriteLine("Bootcampin ilk günü");
//Console.WriteLine(1+45);



//Console.WriteLine("1. sayıyı giriniz.");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2.sayıyı giriniz.");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//int toplam = sayi1 + sayi2;
//Console.WriteLine("iki sayının toplamı:"+sayi1+"+"+sayi2+"="+toplam);
//Yorum satırına alma işlemi ctrl+k+c


//String interpolation
//Console.WriteLine($"2 sayının toplamı : {sayi1}+{sayi2}= {toplam}");

//using System.ComponentModel.Design;

//string ad = "İlker";
//string soyad = "TÜRK ";

//string tamIsim = ad + " " + soyad;


//Console.WriteLine(tamIsim.ToLower());
//Console.WriteLine(tamIsim.Contains("e"));
//Console.WriteLine(tamIsim.Contains("A"));


//double ondalik1 = 10.5;
//double ondalik2 = 10.7 ;

////int a = 25;
////int b = 10;


////Console.WriteLine(a/b);
////Console.WriteLine(ondalik1+ondalik2);

////bool veri tipi
////karşılaştırma operatörleri

//Console.WriteLine($"{ondalik1} ve {ondalik2} sayılaı eşit midir= {ondalik1==ondalik2}");
//Console.WriteLine($"{ondalik1} ve {ondalik2} sayılaı eşit değil midir= {ondalik1 != ondalik2}");
//Console.WriteLine($"{ondalik1} ve {ondalik2} den büyük müdür = {ondalik1 > ondalik2}");
//Console.WriteLine($"{ondalik1} ve {ondalik2} den küçük müdür = {ondalik1 < ondalik2}");
//Console.WriteLine($"{ondal{ik1} ve {ondalik2} den büyük eşit midir = {ondalik1 >= ondalik2}");
//Console.WriteLine($"{ondalik1} ve {ondalik2} den küçük eşit midir = {ondalik1 <= ondalik2}");

//kolsoldan girdi alınacak 18 yaş altında ise ehliyet alamaz 18 yaşından büyük eşit ise ehliyet alabilir.

//Console.WriteLine("Lütfen yaşınızı giriniz.");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age >= 18) 
//{
//    Console.WriteLine("Ehliyet alabilir.");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamaz.");

//}

//KULLANICIDAN 1-7 aralığında sayı alın ve hangi güne geliyor ise günün adını ekrana bastırın.
//1.YÖNTEM

//Console.WriteLine("1 den 7 ye kadar bir sayı giriniz.");
//int dayOfWeek = Convert.ToInt32(Console.ReadLine());
//switch (dayOfWeek)
//{
//    case 1: Console.WriteLine("Pazartesi");
//        break;
//    case 2: Console.WriteLine("Salı");
//        break;
//    case 3: Console.WriteLine("Çarşamba");
//        break;
//    case 4: Console.WriteLine("Perşembe");
//        break;
//    case 5: Console.WriteLine("Cuma");
//        break;
//    case 6: Console.WriteLine("Cumartesi");
//        break;
//    case 7: Console.WriteLine("Pazar");
//        break;
//default: Console.WriteLine("yanlış karakter girdiniz.");
//        break; 
//}

//2.YÖNTEM

//string name = dayOfWeek switch
//{
//    1 => "pazartesi",
//    2 => "salı",
//    3 => "çarşamba",
//    4 => "perşembe",
//    5 => "cuma",
//    6 => "cumartesi",
//    7 => "pazar",
//    _=> "geçersiz karakter girdiniz."
//};
//Console.WriteLine(name);

// Döngüler
// ilk 9 sayıyı ekrana bastıran kod
// 1 2 3 4 5 6 7 8 91

//for (int i = 1; i < 10; i++) 
//{
//    Console.WriteLine(i);

//}

//1den 20 ye kadar olan tüm çift sayıları ekrana bastır.
//1. YÖNTEM:

// for (int a = 0; a <=20; a++)
//{
//    if (a%2 ==0)
//    {
//        Console.WriteLine(a);
//    }

//}

//2.YÖNTEM

//for (int i = 0; i <= 20; i+=2) 
//{
//    Console.WriteLine(i);
//}

//seirlerden array oluşturup izmiri yazdırmak istesek
//string[] sehirler = {"Ankara", "İzmir", "Ordu", "İstanbul","Samsun"};
//Console.WriteLine(sehirler[1]);

 
string[] sehirler = { "Ankara", "İzmir", "Ordu", "İstanbul", "Samsun" ,"Bursa"};
//foreach (string s in sehirler)
//{
//    Console.WriteLine(s);
//}

//içerisinde r harfi geçen şehirleri yazdır
//Console.WriteLine("İçerisinde r harfi geçen şehirler : ");

//foreach (string s in sehirler)
//{
//    if (s.Contains("r") == true)
//    {
//        Console.WriteLine(s);
//    }
//}

// İ ile başlayan şehirleri ekrana bastır.

//Console.WriteLine("Şehirlerden İ ile başylayanları ekrana bastır");
//foreach (var s in sehirler)
//{
//    if(s.StartsWith("İ")==true)
//        {
//        Console.WriteLine(s);
//    }

//}

//Console.WriteLine("Şehirlerden a ile biten şehirleri yazdır.");
//foreach (var s in sehirler)
//{
//    if (s.EndsWith("a") == true)
//    {
//        Console.WriteLine(s);

//        }
//}

//bütün kuralları tek if ile || (veya operatörü)


//Console.WriteLine("3 Kuralada uyan bütün şehirler");
//foreach (var s in sehirler)
//{
//    if (s.Contains("a") || s.StartsWith("İ") || s.EndsWith("a"))
//    {
//        Console.WriteLine(s);
//    }
//}
// && ve operatörü 
//Console.WriteLine("3 Kuralın hepsine uyan şehirler");
//foreach (var s in sehirler)
//{
//    if (s.Contains("a") && s.StartsWith("İ") && s.EndsWith("a"))
//    {
//        Console.WriteLine(s);
//    }
//}

//for dönügüsü ile bütün şehir isimlerini yazdır


//for (int i = 0; i<= sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);

//}

//while döngüsü ile şehirleri ekrana bastırma 

//Console.WriteLine("Şehirleri While döngüsü ile ekrana bastırma ");
//int i = 0;
//while(i<sehirler.Length)
//{
//    Console.WriteLine(sehirler[i]);
//    i++;    
//}

//Çarpım tablosu 2 tane for döngüsü kullanarak yapınız 1 den 10 ye kadar

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)

//    {
//        Console.WriteLine($"{i}*{j}={i * j}");
//    }
//}


//* lardan oluşan üçgen 
for(int a=1;a<=6; a++)
{
    for (int b = 1; b <= a; b++)
    {
        Console.Write("*");
    }
        Console.WriteLine();
    }
Console.WriteLine("Bir değişiklik yapıldı");










