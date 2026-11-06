using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0209RashodMaterialov
{
    public int IdRashodMaterialov { get; set; }

    public int IdProizvodstva { get; set; }

    public int IdMateriala { get; set; }

    public string Rashod { get; set; } = null!;

    public virtual _0209Material IdMaterialaNavigation { get; set; } = null!;

    public virtual _0209Proizvodstvo IdProizvodstvaNavigation { get; set; } = null!;
}
