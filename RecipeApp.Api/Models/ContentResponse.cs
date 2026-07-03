public class Rootobject
{
	public int total { get; set; }
	public Item[] items { get; set; }
}

public class Item
{
	public string contentType { get; set; }
	public string name { get; set; }
	public DateTime createDate { get; set; }
	public DateTime updateDate { get; set; }
	public Route route { get; set; }
	public string id { get; set; }
	public Properties properties { get; set; }
	public Cultures cultures { get; set; }
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