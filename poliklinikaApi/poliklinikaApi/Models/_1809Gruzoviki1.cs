using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809Gruzoviki1
{
    public int Id { get; set; }

    public string Nomer { get; set; } = null!;

    public decimal Gruzopodemnost { get; set; }

    public string? Tip { get; set; }

    public string Status { get; set; } = null!;

    public string? Marka { get; set; }

    public decimal? Obyom { get; set; }

    public DateTime? DataTo { get; set; }

    public string? Primechaniya { get; set; }

    public virtual ICollection<_1809Voditeli> _1809Voditelis { get; set; } = new List<_1809Voditeli>();

    public virtual ICollection<_1809Zakazy> _1809Zakazies { get; set; } = new List<_1809Zakazy>();
}
