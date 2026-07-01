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

		public async Task<RecipeDto> GetRecipeAsync()
		{
			return await Task.FromException<RecipeDto>(new NotImplementedException());
		}

		public async Task<List<RecipeDto>> GetRecipesAsync()
		{
			_httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration["Umbraco:CDA:ApiKey"]); // TODO: move this to httpClient configuration in Program.cs
			var response = await _httpClient.GetAsync("/umbraco/delivery/api/v2/content?filter=contentType:recipe");

			return new List<RecipeDto>();
		}
	}
}
