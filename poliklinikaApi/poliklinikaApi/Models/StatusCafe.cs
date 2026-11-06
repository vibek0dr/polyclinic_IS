using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class StatusCafe
{
    public int IdStatus { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<OrderCafe> OrderCaves { get; set; } = new List<OrderCafe>();
}
