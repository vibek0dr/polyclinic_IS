using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Prepodovatel1
{
    public int IdPrepodovatel { get; set; }

    public string? Imya { get; set; }

    public string? Familiya { get; set; }

    public string? Otchestvo { get; set; }

    public string? Adres { get; set; }

    public virtual ICollection<Zanyatie1> Zanyatie1s { get; set; } = new List<Zanyatie1>();
}
