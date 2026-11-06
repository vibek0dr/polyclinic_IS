using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Knigii
{
    public int IdKnigi { get; set; }

    public string? Nazvanie { get; set; }

    public int? GodIzdaniya { get; set; }

    public string? MestoHraneniya { get; set; }

    public int? Razdel { get; set; }

    public int? Izdatelstvo { get; set; }

    public int? KolVoShtukAbon { get; set; }

    public int? KolVoShtukChitZal { get; set; }

    public int? Cena { get; set; }

    public virtual ICollection<AvtorKnigii> AvtorKnigiis { get; set; } = new List<AvtorKnigii>();

    public virtual Izdatelstva? IzdatelstvoNavigation { get; set; }

    public virtual Razdeli? RazdelNavigation { get; set; }
}
