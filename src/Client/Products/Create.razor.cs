﻿using Microsoft.AspNetCore.Components;
using Shared.Products;
using System.Threading.Tasks;

namespace Client.Products
{
    public partial class Create
    {
        private ProductDto.Create product = new();
        [Inject] public IProductService ProductService { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        private async Task CreateProductAsync()
        {
            ProductRequest.Create request = new()
            {
                Product = product
            };

            var response = await ProductService.CreateAsync(request);
            NavigationManager.NavigateTo($"product/{response.ProductId}");
        }
    }
}