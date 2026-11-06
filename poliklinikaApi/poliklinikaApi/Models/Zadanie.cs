using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zadanie
{
    public int Id { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }
}
