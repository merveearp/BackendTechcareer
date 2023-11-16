//classı açtığımızda internaldan publice çektik çünkü her yerden kodun görünür olmasını istiyoruz.
//Price değerine kdv değeri uygulamamız için erişimi engellicez bunuda publicden private a çevirerek yapıcaz.
//private değerler küçük harfle yazılır.

namespace Day_3;
 public class Product
{
    private string name;

    private double price;

    public string getName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public double GetPrice()
    {
        return price;   
    }

    public void SetPrice( double price)
    {
        this.price = price + price * 0.20;
    }

}
