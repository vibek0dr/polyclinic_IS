using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Tovar
{
    public int IdTovar { get; set; }

    public string? Nazvanie { get; set; }

    public string? Cena { get; set; }

    public string? Postavshik { get; set; }
}
