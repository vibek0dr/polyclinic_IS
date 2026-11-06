using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Service1
{
    public int ServiceId { get; set; }

    public string Name { get; set; } = null!;

    public int PriceRub { get; set; }

    public int? DurationMin { get; set; }

    public virtual ICollection<SaleService> SaleServices { get; set; } = new List<SaleService>();
}
