using RecipeApp.Api.Models.DTOs;

namespace RecipeApp.Api.Interfaces
{
	public interface IRecipeService
	{
		Task<RecipeDto> GetRecipeAsync(string id);
		Task<List<RecipeDto>> GetRecipesAsync();
	}
}
