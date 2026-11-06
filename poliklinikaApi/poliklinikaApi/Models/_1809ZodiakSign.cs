using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809ZodiakSign
{
    public int IdZodiakSign { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DateStart { get; set; }

    public DateOnly DateEnd { get; set; }

    public virtual ICollection<Goroskop> Goroskops { get; set; } = new List<Goroskop>();

    public virtual ICollection<_1809User> _1809Users { get; set; } = new List<_1809User>();
}
