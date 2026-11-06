using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Postavshik
{
    public int? IdPostavshik { get; set; }

    public string? Nazvanie { get; set; }

    public string? Kontakti { get; set; }

    public int? Zakaz { get; set; }
}
