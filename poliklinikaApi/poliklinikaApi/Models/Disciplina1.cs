using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Disciplina1
{
    public int IdDisciplina { get; set; }

    public string? Nazvaniye { get; set; }

    public virtual ICollection<Zanyatie1> Zanyatie1s { get; set; } = new List<Zanyatie1>();
}
