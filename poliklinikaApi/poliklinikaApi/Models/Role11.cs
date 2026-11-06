using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Role11
{
    public int IdRole { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<User11> User11s { get; set; } = new List<User11>();
}
