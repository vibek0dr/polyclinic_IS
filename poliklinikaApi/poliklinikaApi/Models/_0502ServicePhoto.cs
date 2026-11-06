using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502ServicePhoto
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public string PhotoPath { get; set; } = null!;

    public virtual _0502Service Service { get; set; } = null!;
}
