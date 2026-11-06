using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ProdajaTovara
{
    public int NomerProdaji { get; set; }

    public int Kolichestvo { get; set; }

    public int? IdTovara { get; set; }

    public int? IdKlienta { get; set; }

    public virtual SpisokKlientov? IdKlientaNavigation { get; set; }

    public virtual SpisokTovarov? IdTovaraNavigation { get; set; }
}
