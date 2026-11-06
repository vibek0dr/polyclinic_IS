using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502Service
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Cost { get; set; }

    public int DurationInSeconds { get; set; }

    public string? Description { get; set; }

    public double? Discount { get; set; }

    public string? MainImagePath { get; set; }

    public virtual ICollection<_0502ClientService> _0502ClientServices { get; set; } = new List<_0502ClientService>();

    public virtual ICollection<_0502ServicePhoto> _0502ServicePhotos { get; set; } = new List<_0502ServicePhoto>();
}
