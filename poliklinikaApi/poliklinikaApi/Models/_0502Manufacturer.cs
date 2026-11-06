using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502Manufacturer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public virtual ICollection<_0502Product> _0502Products { get; set; } = new List<_0502Product>();
}
