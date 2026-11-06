using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302RaschetnyeListki
{
    public int ListokId { get; set; }

    public int SotrudnikId { get; set; }

    public string Period { get; set; } = null!;

    public decimal Oklad { get; set; }

    public decimal Nadbavki { get; set; }

    public decimal Ndfl { get; set; }

    public decimal Itogo { get; set; }

    public virtual _0302Sotrudniki Sotrudnik { get; set; } = null!;
}
