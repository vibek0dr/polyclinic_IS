using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class WaybillGood
{
    public int IdWaybillGoods { get; set; }

    public int IdWaybill { get; set; }

    public int IdGoods { get; set; }

    public int Quantity { get; set; }

    public virtual Goodss IdGoodsNavigation { get; set; } = null!;

    public virtual Waybill IdWaybillNavigation { get; set; } = null!;
}
