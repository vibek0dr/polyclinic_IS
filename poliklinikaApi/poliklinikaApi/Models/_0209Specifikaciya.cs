using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209Specifikaciya
{
    public int IdSpecifikaciya { get; set; }

    public int IdProdukciya { get; set; }

    public int IdMaterial { get; set; }

    public int KolichestvoNaEd { get; set; }

    public virtual _0209Material IdMaterialNavigation { get; set; } = null!;

    public virtual _0209Produkciya IdProdukciyaNavigation { get; set; } = null!;
}
