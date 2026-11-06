using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class GoodType
{
    public int GoodTypeId { get; set; }

    public string? GoodTypeName { get; set; }

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();
}
