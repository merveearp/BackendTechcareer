﻿

using System.Globalization;

namespace Day_3;
public class Book
{
    private string author;
    private double price;
    //Yazar adının baş harfleri küçük ise ilk harflerinş büyük yap.
    public string Author
    {
        get
        {
            return author;
        }
        set
        {
            TextInfo textinfo = CultureInfo.CurrentCulture.TextInfo;
            string capitalizeAuthor = textinfo.ToTitleCase(value);
            author = capitalizeAuthor;

        }
    }
    
    public string Title { get; set; }

    public double Price
    {
        get => price;
        set => price = value + value * 0.20;

    }
    public override string ToString()
    {
        return $"Yazar : {Author} , Başlık : {Title} , Değeri : {Price}";

    }
}
