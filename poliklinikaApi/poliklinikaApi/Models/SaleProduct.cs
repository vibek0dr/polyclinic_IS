using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class SaleProduct
{
    public int IdSaleproducts { get; set; }

    public int SaleId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int PriceRub { get; set; }

    public virtual Products2 Product { get; set; } = null!;

    public virtual Sale Sale { get; set; } = null!;
}
