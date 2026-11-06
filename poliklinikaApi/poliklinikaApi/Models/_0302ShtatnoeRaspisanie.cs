using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302ShtatnoeRaspisanie
{
    public int ShtatId { get; set; }

    public int PodrazdelenieId { get; set; }

    public int DolzhnostId { get; set; }

    public int KolichestvoStavok { get; set; }

    public int ZanyatoStavok { get; set; }

    public virtual _0302Dolzhnosti Dolzhnost { get; set; } = null!;

    public virtual _0302Podrazdeleniya Podrazdelenie { get; set; } = null!;
}
