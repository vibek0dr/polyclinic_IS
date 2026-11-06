using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Tovar3
{
    public int IdTovar { get; set; }

    public string? Nazvanie { get; set; }

    public string? Cena { get; set; }

    public string? Ves { get; set; }

    public int? Postavshik { get; set; }

    public virtual Postasvhik3? PostavshikNavigation { get; set; }

    public virtual ICollection<TovarSklad> TovarSklads { get; set; } = new List<TovarSklad>();
}
