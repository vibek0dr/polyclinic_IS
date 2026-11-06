using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209Produkciya
{
    public int IdProdukciya { get; set; }

    public string? Kod { get; set; }

    public string Naimenovanie { get; set; } = null!;

    public string EdIzmereniya { get; set; } = null!;

    public virtual ICollection<_0209Proizvodstvo> _0209Proizvodstvos { get; set; } = new List<_0209Proizvodstvo>();

    public virtual ICollection<_0209Specifikaciya> _0209Specifikaciyas { get; set; } = new List<_0209Specifikaciya>();
}
