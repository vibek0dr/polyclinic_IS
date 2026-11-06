using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ApplicationGood
{
    public int IdApplicationGoods { get; set; }

    public int IdApplication { get; set; }

    public int IdGoods { get; set; }

    public virtual Goodss IdGoodsNavigation { get; set; } = null!;
}
