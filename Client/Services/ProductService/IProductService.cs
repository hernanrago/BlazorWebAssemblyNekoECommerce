using BlazorWebAssemblyNekoECommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyNekoECommerce.Client.Services.ProductService
{
    interface IProductService
    {
        IEnumerable<Product> Products { get; set; }

        void LoadProducts();
    }
}
