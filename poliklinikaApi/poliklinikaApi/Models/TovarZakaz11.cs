using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class TovarZakaz11
{
    public int IdTovarZakaz { get; set; }

    public int? IdTovar { get; set; }

    public int? IdZakaz { get; set; }

    public string? Kolichestvo { get; set; }

    public virtual Tovar2? IdTovarNavigation { get; set; }

    public virtual Zakaz2? IdZakazNavigation { get; set; }
}
