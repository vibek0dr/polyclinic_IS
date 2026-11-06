using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Tgrewhtew
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Erqfveq> Erqfveqs { get; set; } = new List<Erqfveq>();
}
