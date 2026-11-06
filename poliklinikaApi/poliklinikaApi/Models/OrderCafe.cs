using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class OrderCafe
{
    public int IdOrder { get; set; }

    public int? UserId { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? StatusId { get; set; }

    public int? TotalSum { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual StatusCafe? Status { get; set; }

    public virtual UserCafe? User { get; set; }
}
