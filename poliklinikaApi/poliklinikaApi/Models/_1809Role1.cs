using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809Role1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<_1809User1> _1809User1s { get; set; } = new List<_1809User1>();
}
