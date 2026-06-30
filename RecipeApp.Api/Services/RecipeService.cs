using RecipeApp.Api.Models.DTOs;
using RecipeApp.Api.Interfaces;

namespace RecipeApp.Api.Services
{
	public class RecipeService : IRecipeService
	{
		private HttpClient _httpClient;

		public RecipeService(HttpClient httpClient) 
		{ 
			_httpClient = httpClient;
		}

		public async Task<RecipeDto> GetRecipe()
		{
			//_httpClient.BaseAddress = new Uri("https://api.example.com/recipes");
			//var response = _httpClient.GetAsync("/random").Result;
			//if (response.IsSuccessStatusCode)
			//{
			//	var recipe = response.Content.ReadFromJsonAsync<RecipeDto>().Result;
			//	return recipe;
			//}
			return null;
		}
	}
}
