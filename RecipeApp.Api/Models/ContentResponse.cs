using System.Text.Json.Serialization;

public class Rootobject
{
	public int total { get; set; }
	[JsonPropertyName("items")]
	public Item[] Items { get; set; }
}

public class Item
{
	[JsonPropertyName("contentType")]
	public string ContentType { get; set; }
	[JsonPropertyName("name")]
	public string Name { get; set; }
	[JsonPropertyName("createDate")]
	public DateTime CreateDate { get; set; }
	[JsonPropertyName("updateDate")]
	public DateTime UpdateDate { get; set; }
	[JsonPropertyName("route")]
	public Route Route { get; set; }
	[JsonPropertyName("id")]
	public string Id { get; set; }
	[JsonPropertyName("properties")]
	public Properties Properties { get; set; }
	[JsonPropertyName("cultures")]
	public Cultures Cultures { get; set; }
}

public class Route
{
	public string path { get; set; }
	public object queryString { get; set; }
	public Startitem startItem { get; set; }
}

public class Startitem
{
	public string id { get; set; }
	public string path { get; set; }
}

public class Properties
{
	public Recipeingredient[] recipeIngredients { get; set; }
	public Recipeutensil[] recipeUtensils { get; set; }
	public string[] cookingInstructions { get; set; }
}

public class Recipeingredient
{
	public string contentType { get; set; }
	public string name { get; set; }
	public DateTime createDate { get; set; }
	public DateTime updateDate { get; set; }
	public Route1 route { get; set; }
	public string id { get; set; }
	public Properties1 properties { get; set; }
}

public class Route1
{
	public string path { get; set; }
	public object queryString { get; set; }
	public Startitem1 startItem { get; set; }
}

public class Startitem1
{
	public string id { get; set; }
	public string path { get; set; }
}

public class Properties1
{
}

public class Recipeutensil
{
	public string contentType { get; set; }
	public string name { get; set; }
	public DateTime createDate { get; set; }
	public DateTime updateDate { get; set; }
	public Route2 route { get; set; }
	public string id { get; set; }
	public Properties2 properties { get; set; }
}

public class Route2
{
	public string path { get; set; }
	public object queryString { get; set; }
	public Startitem2 startItem { get; set; }
}

public class Startitem2
{
	public string id { get; set; }
	public string path { get; set; }
}

public class Properties2
{
}

public class Cultures
{
}