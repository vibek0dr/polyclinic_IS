using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class AuditUser
{
    public int Id { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public DateOnly DataRojdeniya { get; set; }

    public string MestoRojdeniya { get; set; } = null!;

    public int? Doljnost { get; set; }

    public virtual AuditDoljnost? DoljnostNavigation { get; set; }
}
