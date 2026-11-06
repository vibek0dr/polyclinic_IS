using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zanyatie1
{
    public int IdZanyatie { get; set; }

    public int? IdPrepodovatel { get; set; }

    public int? IdGruppa { get; set; }

    public int? IdDisciplina { get; set; }

    public DateOnly? Data { get; set; }

    public virtual Disciplina1? IdDisciplinaNavigation { get; set; }

    public virtual Gruppa1? IdGruppaNavigation { get; set; }

    public virtual Prepodovatel1? IdPrepodovatelNavigation { get; set; }
}
