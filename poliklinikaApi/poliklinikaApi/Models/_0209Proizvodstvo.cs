using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209Proizvodstvo
{
    public int IdProizvodstvo { get; set; }

    public int IdProdukcii { get; set; }

    public DateOnly Date { get; set; }

    public int Kolichestvo { get; set; }

    public virtual _0209Produkciya IdProdukciiNavigation { get; set; } = null!;

    public virtual ICollection<_0209RashodMaterialov> _0209RashodMaterialovs { get; set; } = new List<_0209RashodMaterialov>();
}
