using System.Net;

namespace Day_6_efcore.ReturnsModel;

public class ReturnModel<T>
{
    public T Data { get; set; }
    public String Message { get; set; }
    public HttpStatusCode StatusCode { get; set; }

}
