using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Good
{
    public int GoodId { get; set; }

    public string? GoodName { get; set; }

    public int? Type { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual GoodType? TypeNavigation { get; set; }
}
