using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302Podrazdeleniya
{
    public int PodrazdelenieId { get; set; }

    public string Nazvanie { get; set; } = null!;

    public string? Rukovoditel { get; set; }

    public virtual ICollection<_0302ShtatnoeRaspisanie> _0302ShtatnoeRaspisanies { get; set; } = new List<_0302ShtatnoeRaspisanie>();

    public virtual ICollection<_0302Sotrudniki> _0302Sotrudnikis { get; set; } = new List<_0302Sotrudniki>();
}
