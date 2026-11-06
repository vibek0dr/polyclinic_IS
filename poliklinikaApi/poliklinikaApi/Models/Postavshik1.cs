using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Postavshik1
{
    public int IdPostavshika { get; set; }

    public string? Nazvanie { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<Tovar1> Tovar1s { get; set; } = new List<Tovar1>();
}
