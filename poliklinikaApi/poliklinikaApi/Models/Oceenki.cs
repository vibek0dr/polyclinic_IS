using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Oceenki
{
    public int IdPredmeta { get; set; }

    public int? IdStudenta { get; set; }

    public string? Ocenki { get; set; }
}
