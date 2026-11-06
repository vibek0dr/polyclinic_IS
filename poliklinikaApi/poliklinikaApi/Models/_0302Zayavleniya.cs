using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302Zayavleniya
{
    public int ZayavlenieId { get; set; }

    public int SotrudnikId { get; set; }

    public int TipOtpustaId { get; set; }

    public DateOnly DataNachala { get; set; }

    public DateOnly DataOkonchaniya { get; set; }

    public string Status { get; set; } = null!;

    public DateTime DataSozdaniya { get; set; }

    public virtual _0302Sotrudniki Sotrudnik { get; set; } = null!;

    public virtual _0302TipyOtpustov TipOtpusta { get; set; } = null!;
}
