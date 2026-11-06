using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class SpisokSotrudnikov
{
    public int IdSotrudnika { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public string Adres { get; set; } = null!;

    public DateOnly DataRojdeniya { get; set; }

    public decimal Oklad { get; set; }

    public byte[]? Photo { get; set; }

    public virtual ICollection<Raspisaniyee> Raspisaniyees { get; set; } = new List<Raspisaniyee>();
}
