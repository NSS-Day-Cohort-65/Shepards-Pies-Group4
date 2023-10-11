namespace ShepherdsPie.Models;

public class Pizza {
  public int Id { get; set; }
  public int CheeseId { get; set; }
  public Cheese Cheese { get; set; }
  public int SauceId { get; set; }
  public Sauce Sauce { get; set; }
  public int PizzaSizeId { get; set; }
  public int OrderId { get; set; }
  public PizzaSize PizzaSize{ get; set; }
  public List<PizzaTopping> PizzaToppings { get; set; }
  // add calculated property to get the cost of the pizza. Get it from all the pizzatoppings with this pizza as well as the pizza size. 
  public decimal PizzaTotalCost {

  get {
      //intialize total cost
      decimal totalCost = 0;

      if (PizzaSize != null){
       totalCost = PizzaSize.Cost;
      }
      if (PizzaToppings != null)
      {
        foreach (var topping in PizzaToppings)
        {
          totalCost += 0.50M;
        }
      }
      return totalCost;
  }
}

 }