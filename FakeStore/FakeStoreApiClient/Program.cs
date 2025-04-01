
using System.Net.Http.Json;
using FakeStoreApiClient;

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");

var product = await httpClient.GetFromJsonAsync<Product>("products/1");

product.Price = 1000;

var response = await httpClient.PutAsJsonAsync("products/1", product);
Console.WriteLine(await response.Content.ReadAsStringAsync());