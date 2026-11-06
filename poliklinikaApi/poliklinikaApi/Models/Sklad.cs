using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Sklad
{
    public int IdSklad { get; set; }

    public string? Nazvanie { get; set; }

    public string? Adres { get; set; }

    public virtual ICollection<TovarSklad> TovarSklads { get; set; } = new List<TovarSklad>();
}
