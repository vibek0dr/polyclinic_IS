using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Tovar1
{
    public int IdTovar { get; set; }

    public string? Nazvanie { get; set; }

    public int? Postavshik { get; set; }

    public string? Cena { get; set; }

    public virtual Postavshik1? PostavshikNavigation { get; set; }

    public virtual ICollection<Tovarzakaz1> Tovarzakaz1s { get; set; } = new List<Tovarzakaz1>();
}
