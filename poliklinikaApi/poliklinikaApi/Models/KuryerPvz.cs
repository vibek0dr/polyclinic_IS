using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KuryerPvz
{
    public int IdKuryerPvz { get; set; }

    public int? IdKuryer { get; set; }

    public int? IdPvz { get; set; }

    public virtual Kuryer? IdKuryerNavigation { get; set; }

    public virtual PunktVidachi? IdPvzNavigation { get; set; }
}
