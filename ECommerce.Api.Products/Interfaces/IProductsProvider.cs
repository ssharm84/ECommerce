using ECommerce.Api.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Products.Interfaces
{
    interface IProductsProvider
    {
        Task<(bool IsSuccess, IEnumerable<Product>, string ErrorMessage)> GetProductsAsync();

    }
}
