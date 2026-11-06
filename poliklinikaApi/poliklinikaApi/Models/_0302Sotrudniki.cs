using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302Sotrudniki
{
    public int SotrudnikId { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string? Otchestvo { get; set; }

    public string Snils { get; set; } = null!;

    public string? Inn { get; set; }

    public DateOnly DataPriema { get; set; }

    public int PodrazdelenieId { get; set; }

    public int DolzhnostId { get; set; }

    public int? UserId { get; set; }

    public string Status { get; set; } = null!;

    public virtual _0302Dolzhnosti Dolzhnost { get; set; } = null!;

    public virtual _0302Podrazdeleniya Podrazdelenie { get; set; } = null!;

    public virtual _0302User? User { get; set; }

    public virtual ICollection<_0302Bolnichnye> _0302Bolnichnyes { get; set; } = new List<_0302Bolnichnye>();

    public virtual ICollection<_0302OcenkaKompetenciy> _0302OcenkaKompetenciys { get; set; } = new List<_0302OcenkaKompetenciy>();

    public virtual ICollection<_0302RaschetnyeListki> _0302RaschetnyeListkis { get; set; } = new List<_0302RaschetnyeListki>();

    public virtual ICollection<_0302Tabel> _0302Tabels { get; set; } = new List<_0302Tabel>();

    public virtual ICollection<_0302Zayavleniya> _0302Zayavleniyas { get; set; } = new List<_0302Zayavleniya>();
}
