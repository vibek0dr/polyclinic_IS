using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class StoreBalance
{
    public int IdStoreBalance { get; set; }

    public int IdStore { get; set; }

    public int IdGoods { get; set; }

    public int? Quantity { get; set; }

    public virtual Goodss IdGoodsNavigation { get; set; } = null!;

    public virtual Store IdStoreNavigation { get; set; } = null!;
}
