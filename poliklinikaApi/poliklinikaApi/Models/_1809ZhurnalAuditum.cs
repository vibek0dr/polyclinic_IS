using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809ZhurnalAuditum
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string Deystvie { get; set; } = null!;

    public string ImyaSushchnosti { get; set; } = null!;

    public int? IdSushchnosti { get; set; }

    public DateTime Vremya { get; set; }

    public virtual _1809User1? User { get; set; }
}
