using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Trenera
{
    public int IdTrenera { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public DateOnly DataRojdeniya { get; set; }

    public string Zvanie { get; set; } = null!;

    public string Staj { get; set; } = null!;

    public virtual ICollection<Trenirovki> Trenirovkis { get; set; } = new List<Trenirovki>();
}
