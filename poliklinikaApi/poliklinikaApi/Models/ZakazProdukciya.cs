using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class ZakazProdukciya
{
    public int IdZakazProdukciya { get; set; }

    public int? IdZakaza { get; set; }

    public int? IdProdukciyii { get; set; }

    public int? Kolichestvo { get; set; }

    public int? Cena { get; set; }
}
