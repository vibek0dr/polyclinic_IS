using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class DisciplinaPrepodavatel
{
    public int IdDisciplinaPrepodavatel { get; set; }

    public int IdDisciplina { get; set; }

    public int IdPrepodavatel { get; set; }

    public virtual Disciplina IdDisciplinaNavigation { get; set; } = null!;

    public virtual Prepodavatel IdPrepodavatelNavigation { get; set; } = null!;
}
