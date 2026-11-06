using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class PunktVidachi
{
    public int IdPvz { get; set; }

    public string? Adres { get; set; }

    public int? Sotrudnik { get; set; }

    public virtual ICollection<KuryerPvz> KuryerPvzs { get; set; } = new List<KuryerPvz>();

    public virtual SotrudnikPvz? SotrudnikNavigation { get; set; }
}
