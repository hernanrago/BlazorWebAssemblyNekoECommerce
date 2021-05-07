using BlazorWebAssemblyNekoECommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyNekoECommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> Products { get; set; }

        public void LoadProducts()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.Parse("93af8b62-6595-4176-81fd-8c1fbd8b9cf3"),
                    CategoryId = Guid.Parse("2f743355-c978-4e0e-9e38-1730a1cf0889"),
                    Title= "Cat food",
                    Description = "Cat food",
                    Image= "https://dtgxwmigmg3gc.cloudfront.net/imagery/assets/derivations/icon/512/512/true/eyJpZCI6IjY0MWQzYTM3NWVjNGVmYzkyNTBlMzYyODY3YmExNGZkIiwic3RvcmFnZSI6InB1YmxpY19zdG9yZSJ9?signature=1deb52f7e4702cfdd137e4289737ddc95608fb9de78ce878e88a099d73adc607",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product()
                {
                    Id = Guid.Parse("4bd243e3-eef2-40fc-ad2e-d140f219d29a"),
                    CategoryId = Guid.Parse("2f743355-c978-4e0e-9e38-1730a1cf0889"),
                    Title= "Dog food",
                    Description = "Dog food",
                    Image = "https://dtgxwmigmg3gc.cloudfront.net/imagery/assets/derivations/icon/512/512/true/eyJpZCI6ImYwNWM1ZTNhODkzMzYzZmVlMTcwOTM1NzRlMTM2Njk5Iiwic3RvcmFnZSI6InB1YmxpY19zdG9yZSJ9?signature=02b398dcb0a2bce2197a14b48d6c7d7e35390052c3af9df13b4e798825590e4b",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }
            };
        }
    }
}
