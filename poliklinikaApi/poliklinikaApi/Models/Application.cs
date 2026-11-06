using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Application
{
    public int IdApplication { get; set; }

    public int IdUser { get; set; }

    public DateOnly Date { get; set; }

    public int Status { get; set; }

    public int Store { get; set; }

    public int Good { get; set; }

    public int Quantity { get; set; }

    public virtual Goodss GoodNavigation { get; set; } = null!;

    public virtual Userstore IdUser1 { get; set; } = null!;

    public virtual Manager IdUserNavigation { get; set; } = null!;

    public virtual Statuss StatusNavigation { get; set; } = null!;

    public virtual Store StoreNavigation { get; set; } = null!;
}
