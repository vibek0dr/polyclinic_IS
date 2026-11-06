using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Mdk0502StOrder
{
    public int OrderId { get; set; }

    public string OrderStatus { get; set; } = null!;

    public DateTime OrderDeliveryDate { get; set; }

    public int OrderPickupPoint { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? OrderCode { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Mdk0502StOrderProduct> Mdk0502StOrderProducts { get; set; } = new List<Mdk0502StOrderProduct>();

    public virtual Mdk0502StPickupPoint OrderPickupPointNavigation { get; set; } = null!;

    public virtual Mdk0502StUser? User { get; set; }
}
