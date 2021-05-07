using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssemblyNekoECommerce.Shared
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Uri Uri { get; set; }

        public string Icon { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
