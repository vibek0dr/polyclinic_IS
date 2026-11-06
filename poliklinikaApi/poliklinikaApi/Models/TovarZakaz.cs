using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class TovarZakaz
{
    public int? IdZakaz { get; set; }

    public int? IdTovar { get; set; }

    public string? Kolichestvo { get; set; }

    public virtual Tovar? IdTovarNavigation { get; set; }

    public virtual Zakaz? IdZakazNavigation { get; set; }
}
