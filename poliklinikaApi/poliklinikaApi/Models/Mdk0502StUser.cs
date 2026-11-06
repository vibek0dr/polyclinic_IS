using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Mdk0502StUser
{
    public int UserId { get; set; }

    public string UserSurname { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserPatronymic { get; set; } = null!;

    public string UserLogin { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int UserRole { get; set; }

    public virtual ICollection<Mdk0502StOrder> Mdk0502StOrders { get; set; } = new List<Mdk0502StOrder>();

    public virtual Mdk0502StRole UserRoleNavigation { get; set; } = null!;
}
