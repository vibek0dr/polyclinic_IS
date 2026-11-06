using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Store
{
    public int IdStore { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<StoreBalance> StoreBalances { get; set; } = new List<StoreBalance>();

    public virtual ICollection<Waybill> Waybills { get; set; } = new List<Waybill>();
}
