using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class RoleJewel
{
    public int IdRole { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Client2602> Client2602s { get; set; } = new List<Client2602>();
}
