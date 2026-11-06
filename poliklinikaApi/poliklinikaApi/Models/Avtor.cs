using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Avtor
{
    public int IdAvtora { get; set; }

    public string? Fio { get; set; }

    public string? GodiJizni { get; set; }
}
