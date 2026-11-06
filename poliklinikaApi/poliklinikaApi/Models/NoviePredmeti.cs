using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class NoviePredmeti
{
    public int IdPredmeta { get; set; }

    public string? Nazvanie { get; set; }

    public string? Prepodovatel { get; set; }
}
