
using System.Text.Json;

HttpClient client = new HttpClient();
client.BaseAddress = new Uri("https://localhost:7093/api/");

try
{
    HttpResponseMessage response = await client.GetAsync("Categories");
    if (response.IsSuccessStatusCode)
    {
        string jsonResponse = await response.Content.ReadAsStringAsync();
        List<CategoryResponse>? categories = JsonSerializer.Deserialize<List<CategoryResponse>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        if (categories != null)
        {
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.Id}, Title: {category.Title}");
            }
        }
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}

public class CategoryResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
}