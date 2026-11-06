using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Mdk0502StOrderProduct
{
    public int OrderId { get; set; }

    public string ProductArticleNumber { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual Mdk0502StOrder Order { get; set; } = null!;

    public virtual Mdk0502StProduct ProductArticleNumberNavigation { get; set; } = null!;
}
