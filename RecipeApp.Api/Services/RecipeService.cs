using RecipeApp.Api.Models.DTOs;
using RecipeApp.Api.Interfaces;

namespace RecipeApp.Api.Services
{
	public class RecipeService : IRecipeService
	{
		private HttpClient _httpClient;
		private readonly IConfiguration _configuration;

		public RecipeService(HttpClient httpClient, IConfiguration configuration)
		{
			_httpClient = httpClient;
			_configuration = configuration;
		}

		public async Task<RecipeDto> GetRecipeAsync(string id)
		{
			var response = await _httpClient.GetAsync($"/umbraco/delivery/api/v2/content/item/{id}");
			var recipe = await response.Content.ReadFromJsonAsync<Item>();

			var recipeDto = recipe != null ? new RecipeDto
			{
				Id = recipe.Id,
				Name = recipe.Name,
				Date = recipe.UpdateDate,
				Ingredients = recipe.Properties.RecipeIngredients.Select(i => new IngredientDto
				{
					Name = i.Name
				}).ToList(),
				Utensils = recipe.Properties.RecipeUtensils.Select(u => new UtensilDto
				{
					Name = u.Name
				}).ToList(),
				CookingInstructions = recipe.Properties.CookingInstructions.ToList()
			} : null;

			return recipeDto ?? new RecipeDto() { Name = "", Id = "" }; // TODO: better way of doing this?
		}

		public async Task<List<RecipeDto>> GetRecipesAsync()
		{
			var response = await _httpClient.GetAsync("/umbraco/delivery/api/v2/content?filter=contentType:recipe");
			var recipes = await response.Content.ReadFromJsonAsync<RootObject>();

			var recipeDtos = recipes?.Items?.Select(item => new RecipeDto
			{
				Id = item.Id,
				Name = item.Name,
				Date = item.UpdateDate,
				Ingredients = item.Properties.RecipeIngredients.Select(i => new IngredientDto
				{
					Name = i.Name
				}).ToList(),
				Utensils = item.Properties.RecipeUtensils.Select(u => new UtensilDto
				{
					Name = u.Name
				}).ToList(),
				CookingInstructions = item.Properties.CookingInstructions.ToList()
			}).OrderByDescending(r => r.Date).ToList();

			return recipeDtos ?? new List<RecipeDto>();
		}
	}
}