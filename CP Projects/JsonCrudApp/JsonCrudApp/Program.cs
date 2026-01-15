// This line creates a web application builder
var builder = WebApplication.CreateBuilder(args);

// Add services needed for our app
// We'll add CORS to allow our frontend to call the API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// Add JSON data service as a singleton (one instance for entire app)
builder.Services.AddSingleton<JsonCrudApp.Data.JsonDataService>();

// Build our application
var app = builder.Build();

// Use CORS policy we created
app.UseCors("AllowAll");

// Enable static files (so we can serve HTML, CSS, JS from wwwroot)
app.UseStaticFiles();

// API ENDPOINTS

// GET all items
app.MapGet("/api/items", (JsonCrudApp.Data.JsonDataService dataService) =>
{
    // Get all items from our data service
    var items = dataService.GetAllItems();
    return Results.Ok(items);
});

// GET single item by ID
app.MapGet("/api/items/{id}", (int id, JsonCrudApp.Data.JsonDataService dataService) =>
{
    // Get item by ID
    var item = dataService.GetItemById(id);

    if (item == null)
    {
        return Results.NotFound($"Item with ID {id} not found");
    }

    return Results.Ok(item);
});

// POST create new item
app.MapPost("/api/items", async (HttpContext context, JsonCrudApp.Data.JsonDataService dataService) =>
{
    try
    {
        // Read JSON from request body
        var item = await System.Text.Json.JsonSerializer.DeserializeAsync<JsonCrudApp.Models.Item>(
            context.Request.Body,
            new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        if (item == null)
        {
            return Results.BadRequest("Invalid item data");
        }

        // Add item to data store
        var newItem = dataService.AddItem(item);

        // Return created item with location header
        return Results.Created($"/api/items/{newItem.Id}", newItem);
    }
    catch (Exception ex)
    {
        return Results.Problem($"Error creating item: {ex.Message}");
    }
});

// PUT update existing item
app.MapPut("/api/items/{id}", async (int id, HttpContext context, JsonCrudApp.Data.JsonDataService dataService) =>
{
    try
    {
        // Read JSON from request body
        var item = await System.Text.Json.JsonSerializer.DeserializeAsync<JsonCrudApp.Models.Item>(
            context.Request.Body,
            new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        if (item == null || item.Id != id)
        {
            return Results.BadRequest("Invalid item data or ID mismatch");
        }

        // Update item in data store
        bool success = dataService.UpdateItem(item);

        if (!success)
        {
            return Results.NotFound($"Item with ID {id} not found");
        }

        return Results.Ok(item);
    }
    catch (Exception ex)
    {
        return Results.Problem($"Error updating item: {ex.Message}");
    }
});

// DELETE item
app.MapDelete("/api/items/{id}", (int id, JsonCrudApp.Data.JsonDataService dataService) =>
{
    // Delete item from data store
    bool success = dataService.DeleteItem(id);

    if (!success)
    {
        return Results.NotFound($"Item with ID {id} not found");
    }

    return Results.NoContent();
});

// Redirect root URL to index.html
app.MapGet("/", () => Results.Redirect("/index.html"));

// Start the application
app.Run();