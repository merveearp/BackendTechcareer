
using Day_4_BookProject.Consts;

namespace Day_4_BookProject.Exceptions;
public class BookTitleException : Exception
{
    public BookTitleException(string title) :base(Messages.BookTitleExceptionMessage(title)) { }
        
    
}
