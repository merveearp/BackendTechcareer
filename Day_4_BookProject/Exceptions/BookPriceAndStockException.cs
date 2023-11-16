using Day_4_BookProject.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Exceptions;

public class BookPriceAndStockException : Exception
{
    public BookPriceAndStockException(double price , int stock ): base(Messages.BookPriceAndStockExceptionMessage(price, stock))
    {

    }
}
