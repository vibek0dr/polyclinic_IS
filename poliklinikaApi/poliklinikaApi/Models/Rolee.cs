using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Rolee
{
    public string RoleId { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public virtual ICollection<Userrr> Userrrs { get; set; } = new List<Userrr>();
}
