using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Core.Models;

namespace Magazine.Core.Services
{
    internal interface IProductService
    {
        Product Add(Product product)
        {
            //Adding...
            return product;
        }

        Product Remove(Product product)
        {
            //Removing...
            return product;
        }

        Product Edit(Product product)
        {
            //Editing...
            return product;
        }

        Product Search(Product product)
        {
            //Searching...
            return product;
        }
    }
}
