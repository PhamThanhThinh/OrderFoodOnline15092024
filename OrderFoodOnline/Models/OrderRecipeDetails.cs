namespace OrderFoodOnline.Models
{
  public class OrderRecipeDetails
  {
    public string? Id { get; set; }
    // thời gian nấu món ăn
    public string? CookingTime { get; set; }
    public string? Image_URL { get; set; }
    public string? Publisher { get; set; }
    public string? Title { get; set; }
    //public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public List<Ingredient> Ingredients { get; set; }
    public OrderRecipeDetails()
    {
      Ingredients = new List<Ingredient>();
    }
  }
  public class Ingredient
  {
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public string? Unit { get; set; }
  }
}
