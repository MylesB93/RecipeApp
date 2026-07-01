using RecipeApp.Api.Models.DTOs;

namespace RecipeApp.Api.Interfaces
{
	public interface IRecipeService
	{
		Task<RecipeDto> GetRecipeAsync();
		Task<List<RecipeDto>> GetRecipesAsync()
	}
}
