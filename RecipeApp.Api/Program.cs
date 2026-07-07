using Microsoft.AspNetCore.Mvc;
using RecipeApp.Api.Interfaces;
using RecipeApp.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddScoped<IRecipeService, RecipeService>();

builder.Services.AddHttpClient<IRecipeService, RecipeService>((sp, client) =>
{
	var configuration = sp.GetRequiredService<IConfiguration>();

	client.BaseAddress = new Uri(configuration["Umbraco:CDA:BaseUrl"]!);

	client.DefaultRequestHeaders.Add(
		"X-Api-Key",
		configuration["Umbraco:CDA:ApiKey"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/recipes", async ([FromServices] IRecipeService recipeService) =>
{
	var recipe = await recipeService.GetRecipesAsync();
	return recipe;
})
.WithName("GetRecipe");

app.MapGet("/recipe/{id}", async ([FromServices] IRecipeService recipeService, string id) =>
{
	var recipe = await recipeService.GetRecipeAsync(id);
	return recipe;
})
.WithName("GetRecipeById");

app.Run();
