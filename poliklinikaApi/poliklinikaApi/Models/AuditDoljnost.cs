using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class AuditDoljnost
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuditUser> AuditUsers { get; set; } = new List<AuditUser>();
}
