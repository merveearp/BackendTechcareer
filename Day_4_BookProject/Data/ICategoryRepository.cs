﻿using Day_4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_BookProject.Data;
public interface ICategoryRepository : IEntityBaseRepository<Category, string>
{

}