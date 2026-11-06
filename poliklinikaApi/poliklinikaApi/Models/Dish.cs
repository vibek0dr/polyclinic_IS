using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Dish
{
    public int IdDish { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int CategoryId { get; set; }

    public virtual Category1 Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
