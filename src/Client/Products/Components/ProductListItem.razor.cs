using Microsoft.AspNetCore.Components;
using Shared.Products;

namespace Client.Products.Components
{
    public partial class ProductListItem
    {
        
        [Parameter] public ProductDto.Index Product { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        private void NavigateToDetail()
        {
            NavigationManager.NavigateTo($"product/{Product.Id}");
        }
    }


}
