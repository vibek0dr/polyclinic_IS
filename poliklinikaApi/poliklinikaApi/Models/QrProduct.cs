using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class QrProduct
{
    public int IdProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;
}
