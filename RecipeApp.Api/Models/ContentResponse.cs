using System.Text.Json.Serialization;

public class RootObject
{
	[JsonPropertyName("total")]
	public int Total { get; set; }
	[JsonPropertyName("items")]
	public Item[] Items { get; set; }
}

public class Item
{
	[JsonPropertyName("name")]
	public string Name { get; set; }
	[JsonPropertyName("updateDate")]
	public DateTime UpdateDate { get; set; }
	[JsonPropertyName("id")]
	public string Id { get; set; }
	[JsonPropertyName("properties")]
	public Properties Properties { get; set; }
}

public class Properties
{
	[JsonPropertyName("recipeIngredients")]
	public RecipeIngredient[] RecipeIngredients { get; set; }
	[JsonPropertyName("recipeUtensils")]
	public RecipeUtensil[] RecipeUtensils { get; set; }
	[JsonPropertyName("cookingInstructions")]
	public string[] CookingInstructions { get; set; }
}

public class RecipeIngredient
{
	[JsonPropertyName("contentType")]
	public string ContentType { get; set; }
	[JsonPropertyName("name")]
	public string Name { get; set; }
	[JsonPropertyName("updateDate")]
	public DateTime UpdateDate { get; set; }
	[JsonPropertyName("id")]
	public string Id { get; set; }
	[JsonPropertyName("properties")]
	public Properties1 Properties { get; set; }
}

public class Properties1
{
}

public class RecipeUtensil
{
	[JsonPropertyName("contentType")]
	public string ContentType { get; set; }
	[JsonPropertyName("name")]
	public string Name { get; set; }
	[JsonPropertyName("updateDate")]
	public DateTime UpdateDate { get; set; }
	[JsonPropertyName("id")]
	public string Id { get; set; }
	[JsonPropertyName("properties")]
	public Properties2 Properties { get; set; }
}

public class Properties2
{
}