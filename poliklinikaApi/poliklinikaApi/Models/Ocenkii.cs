using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Ocenkii
{
    public int IdOcenki { get; set; }

    public int StudentId { get; set; }

    public int DisciplinaId { get; set; }

    public int PrepodavatelId { get; set; }

    public int Ocenka { get; set; }

    public DateOnly Data { get; set; }

    public bool Udaleno { get; set; }

    public virtual Disciplina Disciplina { get; set; } = null!;

    public virtual Prepodavatel Prepodavatel { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
