using Microsoft.AspNetCore.Components;
using Shared.Products;
using System.Threading.Tasks;


namespace Client.Products
{
    public partial class Detail
    {
        private ProductDto.Detail product;
        [Parameter] public int Id { get; set; }
        [Inject] public IProductService ProductService { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        protected override async Task OnParametersSetAsync()
        {
            ProductRequest.GetDetail request = new() { ProductId = Id };
            var response = await ProductService.GetDetailAsync(request);
            product = response.Product;
        }

        private async Task DeleteProductAsync()
        {
            var request = new ProductRequest.Delete { ProductId = Id };
            await ProductService.DeleteAsync(request);
            NavigationManager.NavigateTo("/");
        }

    }
}
