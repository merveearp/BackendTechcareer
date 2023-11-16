using Day_3_Static;

//Calculator calculator = new Calculator();
//Console.WriteLine("Birinci sayıyı giriniz.");
//int sayi1 =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("İkinci sayıyı giriniz.");
//int sayi2 =Convert.ToInt32(Console.ReadLine());

//calculator.Topla(sayi1,sayi2);
//calculator.Carpma(sayi1,sayi2);
//calculator.Cikarma(sayi1,sayi2);
//calculator.Bolme(sayi1, sayi2);


//static metodtur.
//CalculatorStatic.Topla(sayi1,sayi2);
//CalculatorStatic.Carpma(sayi1,sayi2);
//CalculatorStatic.Cikarma(sayi1 ,sayi2);
//CalculatorStatic.Bolme(sayi1 , sayi2 );

//Biz bir sisteme kayıt olduğumuzda veri tabanında parolalarımız nasıl görünür.
byte[] passwordHash;
Byte[] passwordSalt;
Console.WriteLine("Lütfen şifrenini giriniz.");
string password = Console.ReadLine();

SecurityHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
Console.WriteLine($"Şifreniz : {password}");
Console.WriteLine($"Şifrenizin Hashi : ");
foreach(var hash in passwordHash)
{
    Console.Write(hash);
}
Console.WriteLine($"Şifrenizin Saltı : {passwordSalt}");
foreach (var salt in passwordSalt)
{
    Console.Write(salt);
}