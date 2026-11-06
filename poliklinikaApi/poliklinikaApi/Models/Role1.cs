using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Role1
{
    public int IdRole { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<User1> User1s { get; set; } = new List<User1>();
}
