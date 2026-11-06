using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class JewelStorage
{
    public int IdJewelStorage { get; set; }

    public int IdJewel { get; set; }

    public int IdStorage { get; set; }

    public int? Availability { get; set; }

    public virtual Jewel IdJewelNavigation { get; set; } = null!;

    public virtual Storage IdStorageNavigation { get; set; } = null!;
}
