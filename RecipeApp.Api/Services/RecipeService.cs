using RecipeApp.Api.Models.DTOs;

namespace RecipeApp.Api.Services
{
	public class RecipeService
	{
		private HttpClient _httpClient;

		public RecipeService(HttpClient httpClient) 
		{ 
			_httpClient = httpClient;
		}

		public RecipeDto GetRecipe()
		{
			_httpClient.BaseAddress = new Uri("https://api.example.com/recipes");
			var response = _httpClient.GetAsync("/random").Result;
			if (response.IsSuccessStatusCode)
			{
				var recipe = response.Content.ReadFromJsonAsync<RecipeDto>().Result;
				return recipe;
			}
			return null;
		}
	}
}
