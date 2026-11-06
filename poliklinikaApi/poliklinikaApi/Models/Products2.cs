using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Products2
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public int PriceRub { get; set; }

    public int? StockQuantity { get; set; }

    public virtual ICollection<SaleProduct> SaleProducts { get; set; } = new List<SaleProduct>();
}
