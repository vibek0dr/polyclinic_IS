using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class OrderDetail
{
    public int IdOrder { get; set; }

    public int? ProductId { get; set; }

    public decimal? UnitPrice { get; set; }

    public short? Quantity { get; set; }

    public float? Discount { get; set; }
}
