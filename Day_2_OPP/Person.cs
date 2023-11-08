
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Day_2_OPP;

public class Person
{
    public Person()
        {

        }

    public Person(int age,string name,string surname,string phone)
    {//this keywords sadece bu class için calısır public int tteki age,name vs yi alır.
     //this koymasaydı yukardaki age surname nama phone olarak alıcaktı ve göstermicekti.
        this.age = age;
        this.name = name;  
        this.surname = surname;
        this.phone = phone;
     
    }

    public int age;
    public string name;
    public string surname;
    public string phone;

    public override string ToString()
    {
        return $"kişi adı:{name},kişi soyadı:{surname},kişi yaşı : {age},kişinin telefonu{phone}";
    }

    //Kişinin adı minimum 2 karakterli olmalıdır.
    //Kişinin yaşı 18 den küçük olmamalıdır.
    //Kişinin telefon numarası boş olmamalıdır.
    public static void Add(Person person)
    {
        if (person.name.Length < 2)
        {
            Console.WriteLine("Kişinin adı min 2 karakterli olmalıdır.");
        }

        if (person.age < 18)
        {

            Console.WriteLine("kişinin yaşı 18 den küçük olmamalıdır. ");
        }
         if (string.IsNullOrEmpty(person.phone))
        {
            Console.WriteLine("Kişinin telefon numarası boş olmamalıdır");

        }
        else if(person.name.Length > 2 && person.age > 18 && person.phone !=null)
        {
            Console.WriteLine("Kişi başarıyla eklendi");

        }
    }
}



