using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpSpecializacii
{
    public int KodSpecializacii { get; set; }

    public string NazvanieSpecializacii { get; set; } = null!;

    public virtual ICollection<KpVrachi> KpVrachis { get; set; } = new List<KpVrachi>();
}
