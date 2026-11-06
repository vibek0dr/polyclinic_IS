using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public int IdSeller { get; set; }

    public int IdClient { get; set; }

    public int IdJewel { get; set; }

    public DateTime SaleTime { get; set; }

    public virtual Client2602 IdClientNavigation { get; set; } = null!;

    public virtual Jewel IdJewelNavigation { get; set; } = null!;

    public virtual Seller IdSellerNavigation { get; set; } = null!;
}
