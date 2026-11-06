using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302Bolnichnye
{
    public int BolnichnyId { get; set; }

    public int SotrudnikId { get; set; }

    public string NomerEln { get; set; } = null!;

    public DateOnly DataNachala { get; set; }

    public DateOnly DataOkonchaniya { get; set; }

    public virtual _0302Sotrudniki Sotrudnik { get; set; } = null!;
}
