using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class User3
{
    public int IdSotrudnik { get; set; }

    public string? Imya { get; set; }

    public string? Familiya { get; set; }

    public string? Otchestvo { get; set; }

    public string? Doljnost { get; set; }

    public string? Nomer { get; set; }

    public int? IdRole { get; set; }
}
