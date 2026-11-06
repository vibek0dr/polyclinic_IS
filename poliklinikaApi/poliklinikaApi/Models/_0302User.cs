using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302User
{
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public int RoleId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual _0302Role Role { get; set; } = null!;

    public virtual ICollection<_0302Sotrudniki> _0302Sotrudnikis { get; set; } = new List<_0302Sotrudniki>();
}
