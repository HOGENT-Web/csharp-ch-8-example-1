using Shared.Products;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Client.Products
{
    public class ProductService : IProductService
    {
        private readonly HttpClient client;
        private const string endpoint = "api/product";
        public ProductService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<ProductResponse.Create> CreateAsync(ProductRequest.Create request)
        {
            var response = await client.PostAsJsonAsync(endpoint,request);
            return await response.Content.ReadFromJsonAsync<ProductResponse.Create>();
        }

        public async Task DeleteAsync(ProductRequest.Delete request)
        {
            await client.DeleteAsync($"{endpoint}/{request.ProductId}");
        }

        public async Task<ProductResponse.GetDetail> GetDetailAsync(ProductRequest.GetDetail request)
        {
            var response = await client.GetFromJsonAsync<ProductResponse.GetDetail>($"{endpoint}/{request.ProductId}");
            return response;
        }

        public async Task<ProductResponse.GetIndex> GetIndexAsync(ProductRequest.GetIndex request)
        {
            // Currently not doing anything with the parameters from the request.
            var response = await client.GetFromJsonAsync<ProductResponse.GetIndex>(endpoint);
            return response;
        }
    }
}
