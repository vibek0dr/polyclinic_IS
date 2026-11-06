using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class SaleService
{
    public int SaleServicesId { get; set; }

    public int SaleId { get; set; }

    public int ServiceId { get; set; }

    public int Quantity { get; set; }

    public int TotalPrice { get; set; }

    public virtual Sale Sale { get; set; } = null!;

    public virtual Service1 Service { get; set; } = null!;
}
