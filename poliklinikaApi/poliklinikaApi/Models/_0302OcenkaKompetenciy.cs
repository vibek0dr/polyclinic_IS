using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302OcenkaKompetenciy
{
    public int OcenkaId { get; set; }

    public int SotrudnikId { get; set; }

    public string Period { get; set; } = null!;

    public int Professionalizm { get; set; }

    public int KomandnayaRabota { get; set; }

    public int Iniciativnost { get; set; }

    public int Disciplina { get; set; }

    public string? Kommentariy { get; set; }

    public DateTime DataOcenki { get; set; }

    public virtual _0302Sotrudniki Sotrudnik { get; set; } = null!;
}
