﻿using System.Text.Json.Serialization;

namespace FakeStoreApiClient;
public class Product
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("price")]
    public float Price { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }
}
