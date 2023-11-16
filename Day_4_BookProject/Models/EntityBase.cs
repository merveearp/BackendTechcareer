using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Models;
//Generic programlama 
public abstract class EntityBase<TId>
{
    public TId Id { get; set; }
}

