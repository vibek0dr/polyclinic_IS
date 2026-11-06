using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502ClientService
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int ServiceId { get; set; }

    public DateTime StartTime { get; set; }

    public string? Comment { get; set; }

    public virtual _0502Client Client { get; set; } = null!;

    public virtual _0502Service Service { get; set; } = null!;

    public virtual ICollection<_0502DocumentByService> _0502DocumentByServices { get; set; } = new List<_0502DocumentByService>();

    public virtual ICollection<_0502ProductSale> _0502ProductSales { get; set; } = new List<_0502ProductSale>();
}
