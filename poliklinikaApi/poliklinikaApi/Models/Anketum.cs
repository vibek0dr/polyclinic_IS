using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Anketum
{
    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public string? Gruppa { get; set; }
}
