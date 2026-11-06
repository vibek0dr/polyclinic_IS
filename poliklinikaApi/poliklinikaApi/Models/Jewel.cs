using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Jewel
{
    public int IdJewel { get; set; }

    public string Name { get; set; } = null!;

    public int Kind { get; set; }

    public int Material { get; set; }

    public string Cost { get; set; } = null!;

    public virtual ICollection<JewelStorage> JewelStorages { get; set; } = new List<JewelStorage>();

    public virtual Kind KindNavigation { get; set; } = null!;

    public virtual Material MaterialNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
