using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpRoli
{
    public int KodRoli { get; set; }

    public string NazvanieRoli { get; set; } = null!;

    public virtual ICollection<KpPolzovateli> KpPolzovatelis { get; set; } = new List<KpPolzovateli>();
}
