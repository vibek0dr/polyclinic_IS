using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class UserCafe
{
    public int IdUser { get; set; }

    public string Name { get; set; } = null!;

    public int RoleId { get; set; }

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<OrderCafe> OrderCaves { get; set; } = new List<OrderCafe>();

    public virtual RoleCafe Role { get; set; } = null!;
}
