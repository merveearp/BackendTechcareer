﻿

namespace Day_4_BookProject.Consts;

public class Messages
{
    public static string BookTitleExceptionMessage(string title)
    {
        return $"{title} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı: {title.Length}";
    }

    public static string BookPriceAndStockExceptionMessage(double price, int stock)
    {
        return $"Girdiğiniz stok ve değer bilgisi negatif değerler olamaz .Stok :{stock}, Değeri : {price}";
    }
}
