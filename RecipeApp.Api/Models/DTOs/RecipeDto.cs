namespace RecipeApp.Api.Models.DTOs
{
	public class RecipeDto
	{
		public required string Id { get; set; }
		public required string Name { get; set; }
		public DateTime Date { get; set; }
		public List<IngredientDto> Ingredients { get; set; } = new List<IngredientDto>();
		public List<UtensilDto> Utensils { get; set; } = new List<UtensilDto>();
		public List<string> CookingInstructions { get; set; } = new List<string>();
	}
}
