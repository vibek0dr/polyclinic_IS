using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809User1
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public int RoleId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Email { get; set; }

    public int IsBlocked { get; set; }

    public DateTime? LastLogin { get; set; }

    public virtual _1809Role1 Role { get; set; } = null!;

    public virtual ICollection<_1809IstoriyaStatusov> _1809IstoriyaStatusovs { get; set; } = new List<_1809IstoriyaStatusov>();

    public virtual ICollection<_1809Voditeli> _1809Voditelis { get; set; } = new List<_1809Voditeli>();

    public virtual ICollection<_1809Zakazy> _1809Zakazies { get; set; } = new List<_1809Zakazy>();

    public virtual ICollection<_1809ZhurnalAuditum> _1809ZhurnalAudita { get; set; } = new List<_1809ZhurnalAuditum>();
}
