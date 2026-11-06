using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Disciplina
{
    public int IdDisciplini { get; set; }

    public string Nazvanie { get; set; } = null!;

    public virtual ICollection<DisciplinaPrepodavatel> DisciplinaPrepodavatels { get; set; } = new List<DisciplinaPrepodavatel>();

    public virtual ICollection<Ocenkii> Ocenkiis { get; set; } = new List<Ocenkii>();
}
