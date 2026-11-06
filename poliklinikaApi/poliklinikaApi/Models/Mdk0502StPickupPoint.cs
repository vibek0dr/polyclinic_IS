using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Mdk0502StPickupPoint
{
    public int PickupPointId { get; set; }

    public string PickupPointAddress { get; set; } = null!;

    public virtual ICollection<Mdk0502StOrder> Mdk0502StOrders { get; set; } = new List<Mdk0502StOrder>();
}
