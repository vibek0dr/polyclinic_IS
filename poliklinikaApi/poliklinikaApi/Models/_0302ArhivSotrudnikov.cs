using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302ArhivSotrudnikov
{
    public int ArhivId { get; set; }

    public int SotrudnikId { get; set; }

    public string Fio { get; set; } = null!;

    public string Dolzhnost { get; set; } = null!;

    public string Otdel { get; set; } = null!;

    public DateOnly DataUvolneniya { get; set; }

    public string? Prichina { get; set; }
}
