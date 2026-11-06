using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302TipyOtpustov
{
    public int TipOtpustaId { get; set; }

    public string Nazvanie { get; set; } = null!;

    public virtual ICollection<_0302Zayavleniya> _0302Zayavleniyas { get; set; } = new List<_0302Zayavleniya>();
}
