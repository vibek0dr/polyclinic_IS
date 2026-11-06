using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809Gruzoviki
{
    public int Id { get; set; }

    public string Nomer { get; set; } = null!;

    public decimal Gruzopodemnost { get; set; }

    public string? Tip { get; set; }

    public string Status { get; set; } = null!;
}
