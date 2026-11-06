using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209ZakazProdukciya
{
    public int? IdZakazProdukcii { get; set; }

    public int? IdZakaza { get; set; }

    public int? IdProdukcii { get; set; }

    public string? Kolichestvo { get; set; }

    public string? Cena { get; set; }

    public virtual _0209Produkciya? IdProdukciiNavigation { get; set; }

    public virtual _0209Zakaz? IdZakazaNavigation { get; set; }
}
