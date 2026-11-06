using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Otdel
{
    public int IdOtdela { get; set; }

    public string? Nazvanie { get; set; }

    public int? Sotrudniki { get; set; }

    public int? Rukovoditel { get; set; }

    public virtual Sotrudnikii? RukovoditelNavigation { get; set; }

    public virtual Sotrudnikii? SotrudnikiNavigation { get; set; }
}
