using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up03Avtomobil
{
    public int Kod { get; set; }

    public int KodModeli { get; set; }

    public int God { get; set; }

    public int Probeg { get; set; }

    public string Vin { get; set; } = null!;

    public decimal Cena { get; set; }

    public string? Opisanie { get; set; }

    public int KodStatusa { get; set; }

    public string? PutFoto { get; set; }

    public DateTime DataDobavleniya { get; set; }

    public string? Cvet { get; set; }

    public decimal? ObemDvigatelya { get; set; }

    public int? Moshchnost { get; set; }

    public string? KorobkaPeredach { get; set; }

    public string? TipPrivoda { get; set; }

    public virtual Up03Model KodModeliNavigation { get; set; } = null!;

    public virtual Up03Status KodStatusaNavigation { get; set; } = null!;

    public virtual ICollection<Up03Sdelka> Up03Sdelkas { get; set; } = new List<Up03Sdelka>();
}
