using BlazorWebAssemblyNekoECommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyNekoECommerce.Client.Services.CategoryService
{
    interface ICategoryService
    {
        IEnumerable<Category> Categories { get; set; }

        void LoadCategories();
    }
}
