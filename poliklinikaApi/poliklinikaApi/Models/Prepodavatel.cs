using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Prepodavatel
{
    public int IdPrepodovatelya { get; set; }

    public string Imya { get; set; } = null!;

    public string Familiya { get; set; } = null!;

    public string? Otchestvo { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<DisciplinaPrepodavatel> DisciplinaPrepodavatels { get; set; } = new List<DisciplinaPrepodavatel>();

    public virtual ICollection<Ocenkii> Ocenkiis { get; set; } = new List<Ocenkii>();
}
