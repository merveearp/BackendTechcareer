//Topla(2,6);
//Topla(4,6);

void Topla(int sayi1, int sayi2)
{
    Console.WriteLine(sayi1 + sayi2);

}

//KisiBilgileriYazdir("Merve", "Türk", 27);
//KisiBilgileriYazdir(name: "İlker",surname: "Türk",age: 32);
void KisiBilgileriYazdir(string name, string surname, int age)
{
    Console.WriteLine($"Kişinin adı :{name},Kişinin Soyadı : {surname},Kişinin yaşı : {age}");


}

//Bir hesap makinesi uygulaması yapalım switch:case (if else) kullanarak
//Kullanıcıdan ilk başta 1. sayıyı sonrasında operatörlerden birini almak(string),sonrasında 2. sayıyı alıp 
//sonucu ekrana bastıralım
//Toplama(a,b),Cikarma(a,b),Carpma(a,b),Bölme(a,b)

//Console.WriteLine("Birinci sayıyı giriniz");
//double sayi1 =Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Lütfen işlemlerden birini yazınız(+,-,*,/)");
//string @operator = Console.ReadLine();

//Console.WriteLine("İkinci sayıyı giriniz");
//double sayi2 = Convert.ToDouble(Console.ReadLine());

//switch (@operator)
//{
//    case "+":Toplama(sayi1, sayi2); break;
//    case "-":Cikarma(sayi1, sayi2); break;
//    case "*":Carpma(sayi1, sayi2); break;
//    case "/":Bölme(sayi1, sayi2); break;
//    default:
//        Console.WriteLine("Geçersiz karakter girdiniz");
//        break;

//}



void Toplama(double a, double b)
{
    Console.WriteLine($"{a}+{b}={a + b}");
}
void Cikarma(double a, double b)
{
    Console.WriteLine($"{a}-{b}={a - b}");
}
void Carpma(double a, double b)
{
    Console.WriteLine($"{a}*{b}={a * b}");
}
void Bölme(double a, double b)
{
    Console.WriteLine($"{a}/{b}={a / b}");
}

// ivme ve kütleyi alarak cismin kuvvetini hesaplayan methodu yazalım.
//var sonuc = Kuvvet(4, 5);
//Console.WriteLine(sonuc);
//double Kuvvet (double m, double a)
//{
//    return m*a;
//    }

//Girilen parametrenin faktöriyelini alan metod yazalım.
//iterative
//recursive

var faktoriyelsonuc = Faktoriyel1(6);
Console.WriteLine(faktoriyelsonuc);
int Faktoriyel1(int n)
{
    int sonuc = 1;
    for (int i = 1; i <= n; i++)
    {
        sonuc *= i;
    }
    return sonuc;
}


    var faktoriyelsonuc2 = Faktoriyel2(4);
Console.WriteLine(faktoriyelsonuc2);

int Faktoriyel2(int n)
{
    if (n == 1) return 1;
    return n*Faktoriyel2(n-1);

}

//girilen metni ters çeviren metod
Console.WriteLine(ReverseMetin("Techcareer Bootcamp 2.Gün"));
string ReverseMetin(string metin)

{
    char[] chars = metin.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);   
}

//girilen parametrede en büyük değeri bulma
//int[] sayilar = { 10, 20, 30, 40, 21, 25, 66, 88, 101 };
//Console.WriteLine($"sayilar dizisinin en büyük sayısı : {EnBuyukSayi(sayilar)}");
int EnBuyukSayi(int[] sayilar)
{
    int enBuyuk = int.MinValue;
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i]>enBuyuk) enBuyuk = sayilar[i];

    }
    return enBuyuk;

}

Console.WriteLine(Toplacoklu(1,2,3,4,5,6));
Console.WriteLine(Toplacoklu(-1, -2, -3, -4));
int Toplacoklu(params int[] sayilar)
{
    int sum = 0;
    foreach(var sayi in sayilar)
    {
        sum += sayi;
    }
    return sum;
}

Console.WriteLine(EnBuyukSayiCoklu(1,2,3,4,5,6,7,9,101,108,20,35));
int EnBuyukSayiCoklu(params int[] sayilar)
{
    int enBuyuk = int.MinValue;
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] > enBuyuk) enBuyuk = sayilar[i];

    }
    return enBuyuk;
}


int BolmeİslemiBolum;
int BolmeİslemiKalan;

Bolmeİslemi(15, 10, out BolmeİslemiBolum, out BolmeİslemiKalan);
Console.WriteLine($"Bölme işleminin bölümü : {BolmeİslemiBolum}, kalanı ise :{BolmeİslemiKalan}");

void Bolmeİslemi(int bölünen,int bölen,out int bölüm , out int kalan)
{
    bölüm = bölünen / bölen;
    kalan = bölünen % bölen;

}

Console.WriteLine("ÇARPMA İŞLEMİ : "+Carpmaİslemi(1,2,4,5,10));
int Carpmaİslemi(params int[] sayilar)
{
    int multiply = 1;
    foreach(var sayi in sayilar)
    {
        multiply *= sayi;
    }
    return multiply;
}



//Todo seçtiğim argümanlardan içinde e olan bütün kelimeleri ekrana bastırsın.
EkranaYaz("Elma", "Armut", "Elazığ", "Üzüm", "Meyve", "İlker", "Merve");

void EkranaYaz(params string[] kelimeler)
{
    foreach ( var kelime in kelimeler)
    {
        if (kelime.Contains("e")|| kelime.Contains("E"))
        {
            Console.WriteLine(kelime);
        }
    }
}












