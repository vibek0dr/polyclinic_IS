using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class SpisokKlientov
{
    public int IdKlient { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public string? Adres { get; set; }

    public string Telephone { get; set; } = null!;

    public DateOnly DataRojdeniya { get; set; }

    public byte[]? Photo { get; set; }

    public virtual ICollection<ProdajaAbonementov> ProdajaAbonementovs { get; set; } = new List<ProdajaAbonementov>();

    public virtual ICollection<ProdajaTovara> ProdajaTovaras { get; set; } = new List<ProdajaTovara>();
}
