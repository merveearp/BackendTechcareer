using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3.Managers;

public class CarManager
{
    public void Add(Car car)

    {
        switch(car.Colour) 
        {
            case Colour.Red:
                Console.WriteLine("Arabanın rengi kırmızır.");
                break;
            case Colour.Black:
                Console.WriteLine("Arabanın rengi siyahtır.");
                break;
        }

    }
}
