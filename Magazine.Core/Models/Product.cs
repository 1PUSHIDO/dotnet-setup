﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Core.Models
{
    public class Product
    {
        Guid Id;
        string? Definition, Name, Image;
        int Price;
    }
}