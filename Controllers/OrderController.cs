using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ShepherdsPie.Data;
using ShepherdsPie.Models;

namespace ShepherdsPie.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private ShepherdsPiesDbContext _dbContext;

    public OrderController(ShepherdsPiesDbContext context)
    {
        _dbContext = context;
    }

 [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        return Ok(_dbContext.Orders.ToList());
    }
 [HttpDelete("{id}/delete")]
    [Authorize]
    public IActionResult DeleteOrder(int id)
    {
        Order OrderToDelete = _dbContext.Orders.SingleOrDefault(o => o.Id == id);
        if (OrderToDelete == null)
        {
            return NotFound();
        }
        _dbContext.Orders.Remove(OrderToDelete);
        _dbContext.SaveChanges();
        return NoContent();
    } 
      [HttpGet("{id}")]
    // [Authorize]
    public IActionResult GetById(int id)
    {
        Order order = _dbContext
            .Orders
            
            .Include(o => o.DeliveryDriver)
            .Include(o => o.Pizzas)
            .ThenInclude(p => p.PizzaSize)
            .Include(o => o.Pizzas)
            .ThenInclude(p => p.Sauce)
            .Include(o => o.Pizzas)
            .ThenInclude(p => p.Cheese)
            .Include(o => o.Pizzas)
            .ThenInclude(p => p.PizzaToppings)
            .ThenInclude(pt => pt.Topping)
            .SingleOrDefault(o => o.Id == id);

        if (order == null)
        {
            return NotFound();
        }

        return Ok(order);
    }

}