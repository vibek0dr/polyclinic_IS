using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class OrderItem
{
    public int IdOrderItem { get; set; }

    public int OrderId { get; set; }

    public int DishId { get; set; }

    public int Quantity { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual OrderCafe Order { get; set; } = null!;
}
