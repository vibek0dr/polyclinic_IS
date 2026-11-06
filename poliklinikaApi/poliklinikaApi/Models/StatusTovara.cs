using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class StatusTovara
{
    public int IdStatusa { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<TovarSklad> TovarSklads { get; set; } = new List<TovarSklad>();
}
