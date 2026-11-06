using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Roli
{
    public int IdRoli { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<Sportsmeni> Sportsmenis { get; set; } = new List<Sportsmeni>();
}
