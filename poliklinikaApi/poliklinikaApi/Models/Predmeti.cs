using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Predmeti
{
    public int IdPredmeta { get; set; }

    public string Nazvanie { get; set; } = null!;

    public string Prepodovatel { get; set; } = null!;
}
