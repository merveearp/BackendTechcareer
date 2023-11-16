

namespace Day_3_Inheritance;

public class Product : EntityBase
{
    
    public string Name { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return $"Id : {Id} , Kim oluşturdu : {CreatedBy} , Ne Zaman : {CreateDate} , Adı : {Name} , Değeri : {Price}";
    }
}
