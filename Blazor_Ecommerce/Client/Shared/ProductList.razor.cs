using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Blazor_Ecommerce.Client.Shared
{
    public partial class ProductList : ComponentBase
    {
        private static List<Product> Products = new List<Product>();

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<List<Product>>("api/Product");
            if(result is not null)
                Products = result;
        }
    }
}
