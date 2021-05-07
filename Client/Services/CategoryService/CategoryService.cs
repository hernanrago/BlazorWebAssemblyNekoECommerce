using BlazorWebAssemblyNekoECommerce.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyNekoECommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly NavigationManager _navManager;
        public CategoryService(NavigationManager navManager)
        {
            _navManager = navManager;
        }

        public IEnumerable<Category> Categories { get; set; }

        public void LoadCategories()
        {
            Categories = new List<Category>()
            {
                new Category() { Id = Guid.Parse("2f743355-c978-4e0e-9e38-1730a1cf0889"), Name = "Food", Icon = "food", Uri = new Uri($"{_navManager.BaseUri}category/{"2f743355-c978-4e0e-9e38-1730a1cf0889"}")  }
            };
        }
    }
}
