using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Tovarzakaz1
{
    public int IdTovarZakaz { get; set; }

    public int? Tovar { get; set; }

    public int? Zakaz { get; set; }

    public string? Kolichestvo { get; set; }

    public virtual Tovar1? TovarNavigation { get; set; }

    public virtual Zakaz1? ZakazNavigation { get; set; }
}
