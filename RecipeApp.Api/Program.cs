using RecipeApp.Api.Interfaces;
using RecipeApp.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddScoped<IRecipeService, RecipeService>();

builder.Services.AddHttpClient<IRecipeService, RecipeService>(c => c.BaseAddress = new System.Uri("https://localhost:44398/"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/", async (RecipeService recipeService) =>
{
	var recipe = await recipeService.GetRecipe();
	return recipe;
})
.WithName("GetRecipe");

app.Run();
