using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpPolzovateli
{
    public int KodPolzovatelya { get; set; }

    public string Login { get; set; } = null!;

    public string Parol { get; set; } = null!;

    public int KodRoli { get; set; }

    public virtual KpRoli KodRoliNavigation { get; set; } = null!;

    public virtual ICollection<KpVrachi> KpVrachis { get; set; } = new List<KpVrachi>();
}
