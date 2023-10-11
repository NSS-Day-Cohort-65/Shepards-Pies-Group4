using System.ComponentModel.DataAnnotations.Schema;
using ShepardsPie.Models;

public class Order {
  public int Id { get; set; }
  public int UserProfileId { get; set; }
  [ForeignKey("EmployeeRecieverId")]
  public UserProfile EmployeeRecieverId { get; set; }
  public int? DeliveryDriverId { get; set; }
  [ForeignKey("DeliveryDriverId")]
  public UserProfile DeliveryDriver { get; set; }
  public int TableId { get; set; }
  public DateTime TimePlaced { get; set;}
  public List<Pizza> Pizzas { get; set; }
  public decimal TipAmount { get; set; }
  
  public decimal? TotalOrderCost {
  
  get
  {
      decimal totalCost = 0;
      if (Pizzas != null && Pizzas.Count > 0)
      {
      foreach(Pizza pizza in Pizzas){
          totalCost += pizza.PizzaTotalCost;
      }
      }

      if (DeliveryDriverId != null)
      {
        //delivery surcharge
        totalCost += 5.00M;
      }

      totalCost += TipAmount;
      return totalCost;
  }

  }


  
}