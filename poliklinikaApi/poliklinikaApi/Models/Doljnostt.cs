using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Doljnostt
{
    public int IdDoljnosti { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<Sotrudnikii> Sotrudnikiis { get; set; } = new List<Sotrudnikii>();
}
