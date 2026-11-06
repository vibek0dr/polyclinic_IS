using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502ProductSale
{
    public int Id { get; set; }

    public DateTime SaleDate { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int? ClientServiceId { get; set; }

    public virtual _0502ClientService? ClientService { get; set; }
}
